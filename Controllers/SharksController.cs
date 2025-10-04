using Microsoft.AspNetCore.Mvc;
using sharks.Models;
using sharks.Data;

namespace sharks.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SharksController : ControllerBase
    {
        private readonly ILogger<SharksController> _logger;

        public SharksController(ILogger<SharksController> logger)
        {
            _logger = logger;
        }

        [HttpGet("species")]
        public ActionResult<IEnumerable<SharkSpecies>> GetSharkSpecies()
        {
            var species = SharkSpeciesSeedData.GetSharkSpecies();
            return Ok(species);
        }

        [HttpGet("species/{id}")]
        public ActionResult<SharkSpecies> GetSharkSpecies(int id)
        {
            var species = SharkSpeciesSeedData.GetSharkSpecies().FirstOrDefault(s => s.Id == id);

            if (species == null)
            {
                return NotFound($"Shark species with ID {id} not found.");
            }

            return Ok(species);
        }

        [HttpGet("sample-data")]
        public ActionResult<object> GetSampleSharkData()
        {
            // Datos de ejemplo basados en el CSV proporcionado
            var sampleShark = new Shark
            {
                Id = 3,
                Name = "Bruce",
                TagId = "TAG-003",
                Gender = "Male",
                Length = 4.5,
                Weight = 800.0,
                TaggedDate = DateTime.Parse("2013-12-01"),
                TaggedLocation = "Sudáfrica",
                Notes = "Tiburón adulto saludable",
                SharkSpeciesId = 1 // Tiburón Blanco
            };

            var sampleTrackingData = new List<SharkTracking>
            {
                new SharkTracking { Id = 1, SharkId = 3, Latitude = -34.60661m, Longitude = 21.15244m, TrackingDateTime = DateTime.Parse("2014-07-06 04:57:28") },
                new SharkTracking { Id = 2, SharkId = 3, Latitude = -34.78752m, Longitude = 19.42479m, TrackingDateTime = DateTime.Parse("2014-06-23 02:40:09") },
                new SharkTracking { Id = 3, SharkId = 3, Latitude = -34.42487m, Longitude = 21.09754m, TrackingDateTime = DateTime.Parse("2014-06-15 13:15:44") },
                new SharkTracking { Id = 4, SharkId = 3, Latitude = -34.70432272m, Longitude = 20.21013441m, TrackingDateTime = DateTime.Parse("2014-06-03 02:23:57") },
                new SharkTracking { Id = 5, SharkId = 3, Latitude = -34.65556m, Longitude = 19.37459m, TrackingDateTime = DateTime.Parse("2014-05-28 19:53:57") }
            };

            return Ok(new { shark = sampleShark, trackingData = sampleTrackingData });
        }

        [HttpGet("{sharkId}/tracking")]
        public ActionResult<IEnumerable<SharkTracking>> GetSharkTracking(int sharkId)
        {
            // Datos de ejemplo para demostración
            var trackingData = new List<SharkTracking>
            {
                new SharkTracking { Id = 1, SharkId = sharkId, Latitude = -34.60661m, Longitude = 21.15244m, TrackingDateTime = DateTime.Parse("2014-07-06 04:57:28") },
                new SharkTracking { Id = 2, SharkId = sharkId, Latitude = -34.78752m, Longitude = 19.42479m, TrackingDateTime = DateTime.Parse("2014-06-23 02:40:09") },
                new SharkTracking { Id = 3, SharkId = sharkId, Latitude = -34.42487m, Longitude = 21.09754m, TrackingDateTime = DateTime.Parse("2014-06-15 13:15:44") }
            };

            return Ok(trackingData);
        }
    }
}
