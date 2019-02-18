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
            sut = new CardsController(mockContext);
        }

        private FiveRingsDbContext SetupMock()
        {
            var mockContext = Substitute.For<FiveRingsDbContext>(new DbContextOptions<FiveRingsDbContext>());

            var cards = new List<Card>
            {
                new EventCard {Id = "way-of-the-phoenix"},
                new AttachmentCard {Id = "fine-katana"},
                new StrongholdCard {Id = "isawa-mori-seido"}
            }.AsQueryable();

            var mockCards = Substitute.For<DbSet<Card>, IQueryable<Card>>();
            ((IQueryable<Card>)mockCards).Provider.Returns(cards.Provider);
            ((IQueryable<Card>)mockCards).Expression.Returns(cards.Expression);
            ((IQueryable<Card>)mockCards).ElementType.Returns(cards.ElementType);
            ((IQueryable<Card>)mockCards).GetEnumerator().Returns(cards.GetEnumerator());

            return mockContext;
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
