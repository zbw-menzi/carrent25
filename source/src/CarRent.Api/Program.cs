
namespace CarRent.Api
{
    using CarRent.Api.Cars;
    using CarRent.Domain.Cars;
    using CarRent.Infrastructure.Persistence;
    using CarRent.Infrastructure.Persistence.Cars;

    using Microsoft.EntityFrameworkCore;

    public static class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddAuthorization();

            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();


            builder.Services.AddDbContext<CarRentContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("CarRentDatabase"));
            });

            builder.Services.AddScoped<ICarRepository, CarRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.MapGet("/cars", CarApi.GetCars);

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.Run();
        }
    }
}
