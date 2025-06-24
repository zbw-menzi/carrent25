namespace CarRent.Domain.Cars
{
    using CarRent.Domain.Primitives;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class CarCreatedDomainEvent : IDomainEvent
    {
        public CarCreatedDomainEvent(Car car)
        {
            Car = car;
        }

        public Car Car { get; }
    }
}
