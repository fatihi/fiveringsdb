using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FiveRingsDb.Controllers
{
    public class CardRulingsController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetRulings()
        {
            return NoContent();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRuling()
        {
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRuling()
        {
            return NoContent();
        }
    }
}