using FiveRingsDb.Controllers;
using NUnit.Framework;
using FluentAssertions;

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
            var result = sut.Get();
            result.Value.Should().BeEquivalentTo(new string[] { "value1", "value2" });
        }
    }
}