using Microsoft.AspNetCore.Mvc;
using sharks.DTOs;
using sharks.Services;

namespace sharks.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SharksController : ControllerBase
    {
        private readonly ISharkService _sharkService;

        public SharksController(ISharkService sharkService)
        {
            _sharkService = sharkService;
        }

        /// <summary>
        /// Obtiene la lista de todos los tiburones con su especie
        /// </summary>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SharkDto>>> GetAllSharks()
        {
            var sharks = await _sharkService.GetAllSharksAsync();
            return Ok(sharks);
        }
    }
}
