namespace CarRent.Api.Cars
{
    using CarRent.Domain.Cars;

    using Microsoft.AspNetCore.Http;

    using System;
    using System.Threading.Tasks;

    public class CarApi
    {
        //internal static async Task GetCars(HttpContext context)
        //{
        //    var repo = context.RequestServices.GetRequiredService<ICarRepository>();

        //}

        internal static async Task<IReadOnlyList<GetCarsResponse>> GetCars(
            ICarRepository repository,
            CancellationToken cancellationToken = default)
        {
            return [new GetCarsResponse { Id = Guid.NewGuid() }];
        }
    }
}
