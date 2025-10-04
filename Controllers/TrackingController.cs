using Microsoft.AspNetCore.Mvc;
using sharks.DTOs;
using sharks.Services;

namespace sharks.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TrackingController : ControllerBase
    {
        private readonly ISharkTrackingService _trackingService;
        private readonly ILogger<TrackingController> _logger;

        public TrackingController(ISharkTrackingService trackingService, ILogger<TrackingController> logger)
        {
            _trackingService = trackingService;
            _logger = logger;
        }

        /// <summary>
        /// Obtiene todos los datos de tracking de un tiburón específico
        /// </summary>
        [HttpGet("shark/{sharkId}")]
        public async Task<ActionResult<IEnumerable<SharkTrackingDto>>> GetTrackingBySharkId(int sharkId)
        {
            try
            {
                var trackingData = await _trackingService.GetTrackingBySharkIdAsync(sharkId);
                return Ok(trackingData);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener tracking del tiburón {SharkId}", sharkId);
                return StatusCode(500, "Error interno del servidor");
            }
        }
    }
}
