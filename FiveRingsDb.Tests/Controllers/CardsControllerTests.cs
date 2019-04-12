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
            mockContext.Cards.AddRange(
                new EventCard { Id = "way-of-the-phoenix" },
                new AttachmentCard { Id = "fine-katana" },
                new StrongholdCard { Id = "isawa-mori-seido" },
                new CharacterCard { Id = "kitsuki-yaruma" });
        }

        private FiveRingsDbContext SetupMock()
        {
            var optionsBuilder = new DbContextOptionsBuilder<FiveRingsDbContext>();
            optionsBuilder.UseInMemoryDatabase("cards_db");
            return new FiveRingsDbContext(optionsBuilder.Options);
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
