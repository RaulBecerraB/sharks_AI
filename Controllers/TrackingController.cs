using Microsoft.AspNetCore.Mvc;
using sharks.Models;

namespace sharks.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TrackingController : ControllerBase
    {
        private readonly ILogger<TrackingController> _logger;

        public TrackingController(ILogger<TrackingController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<IEnumerable<SharkTracking>> GetAllTracking()
        {
            // Datos de ejemplo basados en el CSV proporcionado
            var trackingData = new List<SharkTracking>
            {
                new SharkTracking { Id = 1, SharkId = 3, Latitude = -34.60661m, Longitude = 21.15244m, TrackingDateTime = DateTime.Parse("2014-07-06 04:57:28"), Temperature = 18.5, Depth = 45.2 },
                new SharkTracking { Id = 2, SharkId = 3, Latitude = -34.78752m, Longitude = 19.42479m, TrackingDateTime = DateTime.Parse("2014-06-23 02:40:09"), Temperature = 17.8, Depth = 32.1 },
                new SharkTracking { Id = 3, SharkId = 3, Latitude = -34.42487m, Longitude = 21.09754m, TrackingDateTime = DateTime.Parse("2014-06-15 13:15:44"), Temperature = 19.2, Depth = 28.7 },
                new SharkTracking { Id = 4, SharkId = 3, Latitude = -34.70432272m, Longitude = 20.21013441m, TrackingDateTime = DateTime.Parse("2014-06-03 02:23:57"), Temperature = 18.9, Depth = 41.3 },
                new SharkTracking { Id = 5, SharkId = 3, Latitude = -34.65556m, Longitude = 19.37459m, TrackingDateTime = DateTime.Parse("2014-05-28 19:53:57"), Temperature = 17.5, Depth = 35.6 },
                new SharkTracking { Id = 6, SharkId = 3, Latitude = -34.63245m, Longitude = 19.42612m, TrackingDateTime = DateTime.Parse("2014-04-11 00:56:06"), Temperature = 16.8, Depth = 22.4 },
                new SharkTracking { Id = 7, SharkId = 3, Latitude = -34.62952m, Longitude = 19.42943m, TrackingDateTime = DateTime.Parse("2014-04-10 03:04:58"), Temperature = 16.9, Depth = 24.1 },
                new SharkTracking { Id = 8, SharkId = 3, Latitude = -34.62948m, Longitude = 19.42926m, TrackingDateTime = DateTime.Parse("2014-04-10 01:11:30"), Temperature = 16.7, Depth = 23.8 },
                new SharkTracking { Id = 9, SharkId = 3, Latitude = -34.64901797m, Longitude = 20.29276432m, TrackingDateTime = DateTime.Parse("2014-01-16 04:30:50"), Temperature = 20.1, Depth = 38.9 },
                new SharkTracking { Id = 10, SharkId = 3, Latitude = -34.66521297m, Longitude = 20.26497576m, TrackingDateTime = DateTime.Parse("2014-01-10 13:20:14"), Temperature = 19.8, Depth = 42.3 },
                new SharkTracking { Id = 11, SharkId = 3, Latitude = -34.81799m, Longitude = 20.23152m, TrackingDateTime = DateTime.Parse("2014-01-08 01:23:54"), Temperature = 19.5, Depth = 36.7 },
                new SharkTracking { Id = 12, SharkId = 3, Latitude = -34.71725348m, Longitude = 20.13079566m, TrackingDateTime = DateTime.Parse("2013-12-28 00:04:59"), Temperature = 21.2, Depth = 29.5 },
                new SharkTracking { Id = 13, SharkId = 3, Latitude = -34.71818947m, Longitude = 20.12474436m, TrackingDateTime = DateTime.Parse("2013-12-27 14:15:25"), Temperature = 21.0, Depth = 31.2 },
                new SharkTracking { Id = 14, SharkId = 3, Latitude = -34.72023786m, Longitude = 20.11244288m, TrackingDateTime = DateTime.Parse("2013-12-26 08:43:24"), Temperature = 20.8, Depth = 27.9 },
                new SharkTracking { Id = 15, SharkId = 3, Latitude = -34.72199931m, Longitude = 20.11298288m, TrackingDateTime = DateTime.Parse("2013-12-26 07:55:39"), Temperature = 20.7, Depth = 28.1 }
            };

            return Ok(trackingData);
        }

        [HttpGet("{id}")]
        public ActionResult<SharkTracking> GetTrackingById(int id)
        {
            // En una implementación real, esto vendría de una base de datos
            var tracking = new SharkTracking
            {
                Id = id,
                SharkId = 3,
                Latitude = -34.60661m,
                Longitude = 21.15244m,
                TrackingDateTime = DateTime.Parse("2014-07-06 04:57:28"),
                Temperature = 18.5,
                Depth = 45.2,
                Speed = 3.2,
                SignalStrength = "Strong"
            };

            return Ok(tracking);
        }

        [HttpGet("shark/{sharkId}")]
        public ActionResult<IEnumerable<SharkTracking>> GetTrackingBySharkId(int sharkId)
        {
            var trackingData = GetAllTracking().Value?.Where(t => t.SharkId == sharkId);
            return Ok(trackingData);
        }

        [HttpGet("daterange")]
        public ActionResult<IEnumerable<SharkTracking>> GetTrackingByDateRange([FromQuery] DateTime startDate, [FromQuery] DateTime endDate)
        {
            var allTracking = GetAllTracking().Value;
            var filteredData = allTracking?.Where(t => t.TrackingDateTime >= startDate && t.TrackingDateTime <= endDate);
            return Ok(filteredData);
        }

        [HttpPost]
        public ActionResult<SharkTracking> CreateTracking([FromBody] SharkTracking tracking)
        {
            // En una implementación real, esto se guardaría en la base de datos
            tracking.Id = new Random().Next(1000, 9999);
            _logger.LogInformation($"New tracking record created for shark {tracking.SharkId} at {tracking.TrackingDateTime}");
            return CreatedAtAction(nameof(GetTrackingById), new { id = tracking.Id }, tracking);
        }
    }
}
