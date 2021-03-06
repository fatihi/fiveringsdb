using System.Threading.Tasks;
using FiveRingsDb.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FiveRingsDb.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardsController : ControllerBase
    {
        private const int CURRENT_RRG_VERSION = 9;
        private readonly ICardsRepository cardsRepository;

        public CardsController(ICardsRepository cardsRepository)
        {
            this.cardsRepository = cardsRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetCards()
        {
            var cards = await cardsRepository.GetCards();
            var response = new GetCardsResponse
            {
                RrgVersion = CURRENT_RRG_VERSION,
                Records = cards,
                Success = true,
            };

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCard(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var card = await cardsRepository.GetCard(id);
            if (card == null)
            {
                return NotFound();
            }

            return Ok(card);
        }

        [HttpGet("update")]
        public async Task<IActionResult> UpdateCardDatabase()
        {
            cardsRepository.UpdateCardDatabase();

            return Ok();
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
