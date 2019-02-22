using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiveRingsDb.Controllers;
using FiveRingsDb.Models;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
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
            var mockContext = SetupMock();
            AddCards(mockContext);
            sut = new CardsController(mockContext);
        }

        private void AddCards(FiveRingsDbContext mockContext)
        {
            mockContext.Cards.Add(new EventCard { Id = "way-of-the-phoenix" });
        }

        private FiveRingsDbContext SetupMock()
        {
            var optionsBuilder = new DbContextOptionsBuilder();
            optionsBuilder.UseInMemoryDatabase("cards_db");
            return new FiveRingsDbContext(optionsBuilder.Options);

            //var cards = new List<Card>
            //{
            //    new EventCard { Id = "way-of-the-phoenix" },
            //    new AttachmentCard { Id = "fine-katana" },
            //    new StrongholdCard { Id = "isawa-mori-seido" }
            //}.AsQueryable();

            //var mockCards = Substitute.For<DbSet<Card>, IQueryable<Card>>();
            //((IQueryable<Card>)mockCards).Provider.Returns(cards.Provider);
            //((IQueryable<Card>)mockCards).Expression.Returns(cards.Expression);
            //((IQueryable<Card>)mockCards).ElementType.Returns(cards.ElementType);
            //((IQueryable<Card>)mockCards).GetEnumerator().Returns(cards.GetEnumerator());

            //var mockContext = Substitute.For<FiveRingsDbContext>();
            //mockContext.Cards = mockCards;

            //return mockContext;
        }

        [Test]
        public void GetCards_ReturnsValues()
        {
            var result = sut.GetCards();
            result.Status.Should().Be(TaskStatus.RanToCompletion);
        }

        [Test]
        public void GetCard_ReturnsValues()
        {
            var result = sut.GetCard("");
            result.Status.Should().Be(TaskStatus.RanToCompletion);
        }
    }
}
