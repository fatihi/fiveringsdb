﻿using System.Collections.Generic;
using System.Threading.Tasks;
using FiveRingsDb.Controllers.Api;
using FiveRingsDb.Models;
using FiveRingsDb.Repositories;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using NUnit.Framework;

namespace FiveRingsDb.Tests.Controllers
{
    public class CardsControllerTests
    {
        [Test]
        public async Task GetCards_ReturnsValues()
        {
            var cardsList = CreateMockCardsList();
            var mockRepository = Substitute.For<ICardsRepository>();
            mockRepository.GetCards().Returns(cardsList);
            var controller = new CardsController(mockRepository);

            var result = await controller.GetCards() as OkObjectResult;

            var cards = result.Value as List<Card>;
            cards.Count.Should().Be(1);
            cards[0].Id.Should().Be("way-of-the-phoenix");
        }

        [Test]
        public async Task GetCard_ReturnsValue()
        {
            const string cardId = "way-of-the-phoenix";
            var mockRepository = Substitute.For<ICardsRepository>();
            mockRepository.GetCard(cardId).Returns(new EventCard { Id = cardId });
            var controller = new CardsController(mockRepository);

            var result = await controller.GetCard(cardId) as OkObjectResult;

            var card = result.Value as Card;
            card.Id.Should().Be(cardId);
        }

        private static IList<Card> CreateMockCardsList()
        {
            return new List<Card>
            {
                new EventCard
                {
                    Id = "way-of-the-phoenix"
                }
            };
        }
    }
}
