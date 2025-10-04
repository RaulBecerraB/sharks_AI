using sharks.Models;

namespace sharks.Repositories
{
    public interface ISharkRepository
    {
        Task<IEnumerable<Shark>> GetAllSharksAsync();
    }
}
