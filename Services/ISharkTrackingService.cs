using sharks.DTOs;

namespace sharks.Services
{
    public interface ISharkTrackingService
    {
        Task<IEnumerable<SharkTrackingDto>> GetTrackingBySharkIdAsync(int sharkId);
    }
}
