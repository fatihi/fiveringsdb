namespace FiveRingsDb.Controllers
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;

    public class CardRulingsController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetRulings()
        {
            return NoContent();
        }
    }
}
