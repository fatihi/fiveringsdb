using System;
using System.Threading.Tasks;
using FiveRingsDb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FiveRingsDb.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CardsController : ControllerBase
    {
        private readonly FiveRingsDbContext db;

        public CardsController(FiveRingsDbContext fiveRingsDbContext)
        {
            db = fiveRingsDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetCards()
        {
            var cards = await db.Cards.ToListAsync();
            return Ok(cards);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCard(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var card = await db.Cards.FindAsync(id);
            if (card == null)
            {
                return NotFound();
            }

            return Ok(card);
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
