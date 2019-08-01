﻿using System.Linq;
using System.Threading.Tasks;
using FiveRingsDb.Repositories;
using FiveRingsDb.Views.Cards;
using Microsoft.AspNetCore.Mvc;

namespace FiveRingsDb.Controllers
{
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
            var orderedCards = cards.OrderBy(x => x.Name);
            var viewModel = new CardsListViewModel
            {
                Cards = orderedCards
            };

            return View(viewModel);
        }
    }
}