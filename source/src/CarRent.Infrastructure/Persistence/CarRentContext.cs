namespace CarRent.Infrastructure.Persistence
{
    using CarRent.Infrastructure.Persistence.Cars;

    using Microsoft.EntityFrameworkCore;

    public class CarRentContext : DbContext
    {
        public CarRentContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            modelBuilder.ApplyConfiguration(new CarConfiguration());
        }
    }
}
