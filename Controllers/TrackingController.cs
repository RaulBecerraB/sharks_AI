using Microsoft.AspNetCore.Mvc;
using sharks.DTOs;
using sharks.Services;

namespace sharks.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TrackingController : ControllerBase
    {
        private readonly ISharkTrackingService _trackingService;
        private readonly IPredictionService _predictionService;
        private readonly ILogger<TrackingController> _logger;

        public TrackingController(
            ISharkTrackingService trackingService,
            IPredictionService predictionService,
            ILogger<TrackingController> logger)
        {
            _trackingService = trackingService;
            _predictionService = predictionService;
            _logger = logger;
        }

        /// <summary>
        /// Obtiene todos los datos de tracking de un tiburón específico
        /// </summary>
        [HttpGet("shark/{sharkId}")]
        public async Task<ActionResult<IEnumerable<SharkTrackingDto>>> GetTrackingBySharkId(int sharkId)
        {
            try
            {
                var trackingData = await _trackingService.GetTrackingBySharkIdAsync(sharkId);
                return Ok(trackingData);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener tracking del tiburón {SharkId}", sharkId);
                return StatusCode(500, "Error interno del servidor");
            }
        }

        /// <summary>
        /// Predice las próximas posiciones de un tiburón basándose en sus últimas 5 posiciones
        /// </summary>
        [HttpGet("shark/{sharkId}/predict")]
        public async Task<ActionResult<SharkPredictionResultDto>> PredictSharkPositions(
            int sharkId,
            [FromQuery] int iterations = 1)
        {
            try
            {
                if (iterations <= 0 || iterations > 100)
                {
                    return BadRequest("Las iteraciones deben estar entre 1 y 100");
                }

                var prediction = await _predictionService.PredictSharkPositionsAsync(sharkId, iterations);

                if (prediction == null)
                {
                    return NotFound($"No se pudo realizar la predicción para el tiburón {sharkId}. Verifique que el tiburón existe y tiene al menos 5 posiciones de tracking.");
                }

                return Ok(prediction);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al predecir posiciones del tiburón {SharkId}", sharkId);
                return StatusCode(500, "Error interno del servidor");
            }
        }

        /// <summary>
        /// Predice las próximas posiciones de un tiburón blanco específicamente
        /// </summary>
        [HttpGet("white-shark/{sharkId}/predict")]
        public async Task<ActionResult<SharkPredictionResultDto>> PredictWhiteSharkPositions(
            int sharkId,
            [FromQuery] int iterations = 1)
        {
            try
            {
                if (iterations <= 0 || iterations > 100)
                {
                    return BadRequest("Las iteraciones deben estar entre 1 y 100");
                }

                var prediction = await _predictionService.PredictWhiteSharkPositionsAsync(sharkId, iterations);

                if (prediction == null)
                {
                    return NotFound($"No se pudo realizar la predicción para el tiburón blanco {sharkId}. Verifique que el tiburón existe y tiene al menos 5 posiciones de tracking.");
                }

                return Ok(prediction);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al predecir posiciones del tiburón blanco {SharkId}", sharkId);
                return StatusCode(500, "Error interno del servidor");
            }
        }

        /// <summary>
        /// Predice las próximas posiciones de un tiburón limón específicamente
        /// </summary>
        [HttpGet("lemon-shark/{sharkId}/predict")]
        public async Task<ActionResult<SharkPredictionResultDto>> PredictLemonSharkPositions(
            int sharkId,
            [FromQuery] int iterations = 1)
        {
            try
            {
                if (iterations <= 0 || iterations > 100)
                {
                    return BadRequest("Las iteraciones deben estar entre 1 y 100");
                }

                var prediction = await _predictionService.PredictLemonSharkPositionsAsync(sharkId, iterations);

                if (prediction == null)
                {
                    return NotFound($"No se pudo realizar la predicción para el tiburón limón {sharkId}. Verifique que el tiburón existe y tiene al menos 5 posiciones de tracking.");
                }

                return Ok(prediction);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al predecir posiciones del tiburón limón {SharkId}", sharkId);
                return StatusCode(500, "Error interno del servidor");
            }
        }

        /// <summary>
        /// Predice las próximas posiciones de un tiburón martillo específicamente
        /// </summary>
        [HttpGet("hammer-shark/{sharkId}/predict")]
        public async Task<ActionResult<SharkPredictionResultDto>> PredictHammerSharkPositions(
            int sharkId,
            [FromQuery] int iterations = 1)
        {
            try
            {
                if (iterations <= 0 || iterations > 100)
                {
                    return BadRequest("Las iteraciones deben estar entre 1 y 100");
                }

                var prediction = await _predictionService.PredictHammerSharkPositionsAsync(sharkId, iterations);

                if (prediction == null)
                {
                    return NotFound($"No se pudo realizar la predicción para el tiburón martillo {sharkId}. Verifique que el tiburón existe y tiene al menos 5 posiciones de tracking.");
                }

                return Ok(prediction);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al predecir posiciones del tiburón martillo {SharkId}", sharkId);
                return StatusCode(500, "Error interno del servidor");
            }
        }
    }
}
