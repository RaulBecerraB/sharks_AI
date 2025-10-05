using sharks.DTOs;
using sharks.Repositories;

namespace sharks.Services
{
    public class SharkTrackingService : ISharkTrackingService
    {
        private readonly ISharkTrackingRepository _repository;

        public SharkTrackingService(ISharkTrackingRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<SharkTrackingDto>> GetTrackingBySharkIdAsync(int sharkId)
        {
            var trackingData = await _repository.GetTrackingBySharkIdAsync(sharkId);
            return trackingData.Select(st => new SharkTrackingDto
            {
                Id = st.Id,
                SharkId = st.SharkId,
                SharkName = st.Shark?.Name ?? "Unknown",
                Latitude = st.Latitude,
                Longitude = st.Longitude,
                TrackingDateTime = st.TrackingDateTime,
                ChlorA = st.ChlorA
            });
        }
    }
}
