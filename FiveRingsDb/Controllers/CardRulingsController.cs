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
    }
}