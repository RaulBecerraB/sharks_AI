using sharks.DTOs;

namespace sharks.Services
{
    public interface ISharkService
    {
        Task<IEnumerable<SharkDto>> GetAllSharksAsync();
    }
}
