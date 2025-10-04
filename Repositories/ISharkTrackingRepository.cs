using sharks.Models;

namespace sharks.Repositories
{
    public interface ISharkTrackingRepository
    {
        Task<IEnumerable<SharkTracking>> GetTrackingBySharkIdAsync(int sharkId);
    }
}
