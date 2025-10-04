using sharks.DTOs;

namespace sharks.Services
{
    public interface IPredictionService
    {
        Task<SharkPredictionResultDto?> PredictSharkPositionsAsync(int sharkId, int iterations);
    }
}
