using FiveRingsDb.Controllers;
using NUnit.Framework;
using FluentAssertions;

namespace FiveRingsDb.Tests.Controllers
{
    public class CardsControllerTests
    {
        private CardsController cardsController;

        [SetUp]
        public void Setup()
        {
            cardsController = new CardsController();
        }

        [Test]
        public void Get_ReturnsValues()
        {
            var result = cardsController.GetCard();
            result.Should().BeEquivalentTo(new string[] { "Not yet implemented" });
        }
    }
}