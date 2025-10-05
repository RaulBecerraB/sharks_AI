using sharks.DTOs;
using sharks.Repositories;
using System.Text;
using System.Text.Json;

namespace sharks.Services
{
    public class PredictionService : IPredictionService
    {
        private readonly ISharkTrackingRepository _trackingRepository;
        private readonly ISharkRepository _sharkRepository;
        private readonly HttpClient _httpClient;
        private readonly ILogger<PredictionService> _logger;
        private const string PREDICTION_API_URL = "http://localhost:8001/predict/white-shark";

        public PredictionService(
            ISharkTrackingRepository trackingRepository,
            ISharkRepository sharkRepository,
            HttpClient httpClient,
            ILogger<PredictionService> logger)
        {
            _trackingRepository = trackingRepository;
            _sharkRepository = sharkRepository;
            _httpClient = httpClient;
            _logger = logger;
        }

        public async Task<SharkPredictionResultDto?> PredictSharkPositionsAsync(int sharkId, int iterations)
        {
            try
            {
                // Obtener el tiburón
                var shark = await _sharkRepository.GetSharkByIdAsync(sharkId);
                if (shark == null)
                {
                    _logger.LogWarning("Shark with ID {SharkId} not found", sharkId);
                    return null;
                }

                // Obtener las últimas 5 posiciones del tiburón
                var trackingData = await _trackingRepository.GetTrackingBySharkIdAsync(sharkId);
                var lastPositions = trackingData
                    .OrderByDescending(t => t.TrackingDateTime)
                    .Take(5)
                    .Select(t => new PositionDto
                    {
                        Latitude = (double)t.Latitude,
                        Longitude = (double)t.Longitude,
                        Chlor_A = (double)t.ChlorA
                    })
                    .Reverse() // Revertir para tener orden cronológico (más antigua primero)
                    .ToList();

                if (lastPositions.Count < 5)
                {
                    _logger.LogWarning("Shark {SharkId} does not have enough tracking data (found {Count}, need 5)",
                        sharkId, lastPositions.Count);
                    return null;
                }

                var result = new SharkPredictionResultDto
                {
                    SharkId = sharkId,
                    SharkName = shark.Name,
                    UsedPositions = lastPositions,
                    PredictedPositions = new List<PredictedPositionDto>()
                };

                // Lista de posiciones para usar en las predicciones (comenzamos con las últimas 5)
                var positionsForPrediction = new List<PositionDto>(lastPositions);

                // Realizar las predicciones iterativamente
                for (int i = 1; i <= iterations; i++)
                {
                    // Tomar las últimas 5 posiciones para la predicción
                    var currentPositions = positionsForPrediction.TakeLast(5).ToList();

                    var predictedPosition = await CallPredictionApiAsync(currentPositions);
                    if (predictedPosition == null)
                    {
                        _logger.LogError("Failed to get prediction for iteration {Iteration}", i);
                        break;
                    }

                    var predictedPositionDto = new PredictedPositionDto
                    {
                        Latitude = predictedPosition.Predicted_Latitude,
                        Longitude = predictedPosition.Predicted_Longitude,
                        ChlorA = predictedPosition.Predicted_Chlor_A,
                        Iteration = i,
                        PredictedFor = DateTime.UtcNow.AddHours(i) // Estimamos que cada predicción es para la próxima hora
                    };

                    result.PredictedPositions.Add(predictedPositionDto);

                    // Añadir la posición predicha a la lista para la siguiente iteración
                    positionsForPrediction.Add(new PositionDto
                    {
                        Latitude = predictedPosition.Predicted_Latitude,
                        Longitude = predictedPosition.Predicted_Longitude,
                        Chlor_A = predictedPosition.Predicted_Chlor_A
                    });

                    _logger.LogInformation("Completed prediction iteration {Iteration} for shark {SharkId}", i, sharkId);
                }

                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error predicting positions for shark {SharkId}", sharkId);
                return null;
            }
        }

        private async Task<PredictionResponseDto?> CallPredictionApiAsync(List<PositionDto> positions)
        {
            try
            {
                var requestDto = new PredictionRequestDto { Positions = positions };

                // Usar SnakeCaseLower para que coincida con lo que espera la API de ML
                var jsonContent = JsonSerializer.Serialize(requestDto, new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
                    WriteIndented = true
                });

                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                _logger.LogInformation("Calling prediction API at {Url} with positions: {Positions}",
                    PREDICTION_API_URL,
                    string.Join(", ", positions.Select(p => $"({p.Latitude}, {p.Longitude}, {p.Chlor_A})")));

                _logger.LogInformation("Request JSON: {Json}", jsonContent);

                var response = await _httpClient.PostAsync(PREDICTION_API_URL, content);

                _logger.LogInformation("Prediction API response status: {StatusCode}", response.StatusCode);

                if (response.IsSuccessStatusCode)
                {
                    var responseJson = await response.Content.ReadAsStringAsync();
                    _logger.LogInformation("Response JSON: {Json}", responseJson);

                    // Deserializar usando snake_case para el response
                    var predictionResponse = JsonSerializer.Deserialize<PredictionResponseDto>(responseJson,
                        new JsonSerializerOptions
                        {
                            PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
                            PropertyNameCaseInsensitive = true
                        });

                    _logger.LogInformation("Prediction API returned: Lat={Lat}, Lon={Lon}, ChlorA={ChlorA}",
                        predictionResponse?.Predicted_Latitude, predictionResponse?.Predicted_Longitude, predictionResponse?.Predicted_Chlor_A);

                    return predictionResponse;
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError("Prediction API returned error: {StatusCode} - {ReasonPhrase}. Content: {Content}",
                        response.StatusCode, response.ReasonPhrase, errorContent);
                    return null;
                }
            }
            catch (HttpRequestException httpEx)
            {
                _logger.LogError(httpEx, "HTTP error calling prediction API at {Url}. Is the service running?", PREDICTION_API_URL);
                return null;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error calling prediction API");
                return null;
            }
        }
    }
}
