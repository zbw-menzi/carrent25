namespace CarRent.Domain.Cars
{
    using CarRent.Domain.Primitives;

    using System.Collections.Generic;

    public interface ICarRepository : IRepository<Car>
    {
        IReadOnlyList<Car> FindByCarClass(CarClass carClass);
    }
}
