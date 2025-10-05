using sharks.DTOs;

namespace sharks.Services
{
    public interface IPredictionService
    {
        Task<SharkPredictionResultDto?> PredictSharkPositionsAsync(int sharkId, int iterations);
        Task<SharkPredictionResultDto?> PredictWhiteSharkPositionsAsync(int sharkId, int iterations);
        Task<SharkPredictionResultDto?> PredictLemonSharkPositionsAsync(int sharkId, int iterations);
        Task<SharkPredictionResultDto?> PredictHammerSharkPositionsAsync(int sharkId, int iterations);
    }
}
