namespace FiveRingsDb.Tests.Controllers
{
    using FiveRingsDb.Controllers;
    using FluentAssertions;
    using NUnit.Framework;
    using System.Threading.Tasks;

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
            var result = sut.GetCard("");
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
