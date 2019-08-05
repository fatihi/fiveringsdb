using System.Linq;
using System.Threading.Tasks;
using FiveRingsDb.Repositories;
using FiveRingsDb.Views.Cards;
using Microsoft.AspNetCore.Mvc;

namespace FiveRingsDb.Controllers
{
    [Route("[controller]")]
    public class CardsController : Controller
    {
        private readonly ICardsRepository cardsRepository;

        public CardsController(ICardsRepository cardsRepository)
        {
            this.cardsRepository = cardsRepository;
        }

        public async Task<IActionResult> Index()
        {
            var cards = await cardsRepository.GetCards();
            var viewModel = new CardsListViewModel
            {
                Cards = cards
            };

            return View(viewModel);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Card(string id)
        {
            var card = await cardsRepository.GetCard(id);
            return View(card);
        }
    }
}