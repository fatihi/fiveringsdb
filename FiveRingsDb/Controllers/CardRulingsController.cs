using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FiveRingsDb.Controllers
{
    public class CardRulingsController : ControllerBase
    {
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRulings()
        {
            return Ok("Not yet implemented");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRuling()
        {
            return Ok("Not yet implemented");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteRuling()
        {
            return Ok("Not yet implemented");
        }
    }
}