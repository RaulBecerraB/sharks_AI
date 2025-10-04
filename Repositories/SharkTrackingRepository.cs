using Microsoft.EntityFrameworkCore;
using sharks.Data;
using sharks.Models;

namespace sharks.Repositories
{
    public class SharkTrackingRepository : ISharkTrackingRepository
    {
        private readonly SharksDbContext _context;

        public SharkTrackingRepository(SharksDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SharkTracking>> GetTrackingBySharkIdAsync(int sharkId)
        {
            return await _context.SharkTrackings
                .Include(st => st.Shark)
                .ThenInclude(s => s.Species)
                .Where(st => st.SharkId == sharkId)
                .OrderByDescending(st => st.TrackingDateTime)
                .ToListAsync();
        }
    }
}
