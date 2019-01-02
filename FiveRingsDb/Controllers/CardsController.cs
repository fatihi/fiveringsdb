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
        public async Task<IActionResult> GetCard(string id)
        {
            return NoContent();
        }

        [HttpGet("{id}/rulings")]
        public async Task<IActionResult> GetCardRulings(string id)
        {
            return NoContent();
        }

        // TODO create [FromBody] model binding for ruling
        [HttpPost("{id}/rulings")]
        public async Task<IActionResult> AddCardRuling(string id)
        {
            return NoContent();
        }

        // TODO create [FromBody] model binding for ruling
        [HttpPatch("{id}/rulings/{rulingId}")]
        public async Task<IActionResult> ChangeCardRuling(string id, string rulingId)
        {
            return NoContent();
        }

        [HttpGet("{id}/rulings/{rulingId}")]
        public async Task<IActionResult> GetCardRuling(string id, string rulingId)
        {
            return NoContent();
        }

        [HttpGet("{id}/reviews")]
        public async Task<IActionResult> GetReviews(string id)
        {
            return NoContent();
        }

        // TODO create [FromBody] model binding for review
        [HttpPost("{id}/reviews")]
        public async Task<IActionResult> AddReview(string id)
        {
            return NoContent();
        }

        [HttpGet("{id}/reviews/{reviewId}")]
        public async Task<IActionResult> GetReview(string id, string reviewId)
        {
            return NoContent();
        }

        // TODO create [FromBody] model binding for review
        [HttpPatch("{id}/reviews/{reviewId}")]
        public async Task<IActionResult> ChangeReview(string id, string reviewId)
        {
            return NoContent();
        }
    }
}
