using FiveRingsDb.Controllers;
using NUnit.Framework;
using FluentAssertions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FiveRingsDb.Tests.Controllers
{
    public class CardsControllerTests
    {
        private CardsController sut;

        [SetUp]
        public void Setup()
        {
            sut = new CardsController();
        }

        [Test]
        public void GetCard_ReturnsValues()
        {
            var result = sut.GetCard();
            result.Status.Should().Be(TaskStatus.RanToCompletion);
        }

        [Test]
        public void GetCards_ReturnsValues()
        {
            var result = sut.GetCards();
            result.Status.Should().Be(TaskStatus.RanToCompletion);
        }
    }
}