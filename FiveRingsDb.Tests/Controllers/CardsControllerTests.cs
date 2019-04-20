using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FiveRingsDb.Controllers;
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
        private CardsController sut;

        [SetUp]
        public void Setup()
        {
            ICardsRepository mockRepository = SetupRepository();
            sut = new CardsController(mockRepository);
        }

        private static ICardsRepository SetupRepository()
        {
            var cardsList = CreateMockCardsList();
            var mockRepository = Substitute.For<ICardsRepository>();
            mockRepository.GetCards().Returns(cardsList);
            return mockRepository;
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

        [Test]
        public async Task GetCards_ReturnsValues()
        {
            var result = await sut.GetCards() as OkObjectResult;

            var cards = result.Value as List<Card>;
            cards.Count.Should().Be(1);
            cards[0].Id.Should().Be("way-of-the-phoenix");
        }

        [Test]
        public void GetCard_ReturnsValue()
        {
            var result = sut.GetCard("");
            result.Status.Should().Be(TaskStatus.RanToCompletion);
        }
    }
}
