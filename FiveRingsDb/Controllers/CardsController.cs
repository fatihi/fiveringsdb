using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FiveRingsDb.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CardsController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetCards()
        {
            return NoContent();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCard()
        {
            return NoContent();
        }
    }
}
