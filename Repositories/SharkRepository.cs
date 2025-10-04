using Microsoft.EntityFrameworkCore;
using sharks.Data;
using sharks.Models;

namespace sharks.Repositories
{
    public class SharkRepository : ISharkRepository
    {
        private readonly SharksDbContext _context;

        public SharkRepository(SharksDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Shark>> GetAllSharksAsync()
        {
            return await _context.Sharks
                .Include(s => s.Species)
                .Include(s => s.TrackingData)
                .ToListAsync();
        }
    }
}
