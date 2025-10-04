using sharks.DTOs;
using sharks.Repositories;

namespace sharks.Services
{
    public class SharkService : ISharkService
    {
        private readonly ISharkRepository _sharkRepository;

        public SharkService(ISharkRepository sharkRepository)
        {
            _sharkRepository = sharkRepository;
        }

        public async Task<IEnumerable<SharkDto>> GetAllSharksAsync()
        {
            var sharks = await _sharkRepository.GetAllSharksAsync();

            return sharks.Select(shark => new SharkDto
            {
                Id = shark.Id,
                Name = shark.Name,
                TagId = shark.TagId,
                Gender = shark.Gender,
                Length = shark.Length,
                Weight = shark.Weight,
                TaggedDate = shark.TaggedDate,
                TaggedLocation = shark.TaggedLocation,
                Notes = shark.Notes,
                SpeciesName = shark.Species.Name,
                ScientificName = shark.Species.ScientificName,
                TotalTrackingPoints = shark.TrackingData.Count
            });
        }
    }
}
