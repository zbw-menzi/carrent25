namespace CarRent.Domain.Cars
{
    using CarRent.Domain.Primitives;

    public class Car : Entity, IAggregateRoot
    {
        private Car()
        {
            // NOTE: Will be used by EF-Core
        }

        public static Car Create(/* */)
        {
            var car = new Car();
            car.RegisterDomainEvent(new CarCreatedDomainEvent(car));
            return car;
        }
    }
}
