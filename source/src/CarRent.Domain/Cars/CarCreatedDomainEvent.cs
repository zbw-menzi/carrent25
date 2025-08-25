namespace CarRent.Domain.Cars
{
    using CarRent.Domain.Primitives;

    internal class CarCreatedDomainEvent : IDomainEvent
    {
        public CarCreatedDomainEvent(Car car)
        {
            Car = car;
        }

        public Car Car { get; }
    }
}
