using System.Collections.Generic;
using System.Linq;
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
        private const int CURRENT_RRG_VERSION = 9;

        [Test]
        public async Task GetCards_Should_ReturnAllCards()
        {
            var cardsList = CreateMockCardsList();
            var mockRepository = Substitute.For<ICardsRepository>();
            mockRepository.GetCards().Returns(cardsList);
            var controller = new CardsController(mockRepository);

            var result = await controller.GetCards() as OkObjectResult;

            var response = result.Value as GetCardsResponse;
            var cards = response.Records;
            response.Size.Should().Be(2);
            response.RrgVersion.Should().Be(CURRENT_RRG_VERSION);
            response.Success.Should().BeTrue();
            cards.Count().Should().Be(2);
            cards.Should().Contain(c => c.Id == "way-of-the-phoenix");
            cards.Should().Contain(c => c.Id == "shiba-tsukune");
        }

        [Test]
        public async Task GetCard_Should_ReturnCard_When_CardIdIsProvided()
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
                },
                new CharacterCard()
                {
                    Id = "shiba-tsukune"
                }
            };
        }
    }
}
