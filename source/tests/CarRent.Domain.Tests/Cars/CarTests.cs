namespace CarRent.Domain.Tests.Cars
{
    using AwesomeAssertions;

    using CarRent.Domain.Cars;

    public class CarTests
    {
        [Fact]
        public void Create_WhenCarCreated_ThenDomainEventExists()
        {
            var car = Car.Create();

            car.DomainEvents.Should().HaveCount(1);
        }
    }
}
