namespace CarRent.Infrastructure.Persistence.Cars
{
    using CarRent.Domain.Cars;
    using CarRent.Domain.Primitives;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CarRepository : Repository<Car>, ICarRepository
    {
        public CarRepository(CarRentContext context)
            : base(context)
        {
        }

        public IReadOnlyList<Car> FindByCarClass(CarClass carClass)
        {
            throw new NotImplementedException();
        }
    }
}
