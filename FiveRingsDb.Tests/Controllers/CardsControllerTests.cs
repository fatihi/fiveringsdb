using FiveRingsDb.Controllers;
using NUnit.Framework;
using FluentAssertions;
using System.Threading.Tasks;

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
        public void Get_ReturnsValues()
        {
            var result = sut.GetCard();
            result?.Status.Should().Be(TaskStatus.RanToCompletion);
        }
    }
}