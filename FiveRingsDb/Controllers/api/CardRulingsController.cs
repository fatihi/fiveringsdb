using Microsoft.AspNetCore.Mvc;

namespace FiveRingsDb.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardRulingsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetRulings()
        {
            return NoContent();
        }
    }
}
