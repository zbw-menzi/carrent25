namespace CarRent.Infrastructure.Persistence
{
    using CarRent.Domain.Primitives;
    using CarRent.Infrastructure.Persistence.Cars;

    using Microsoft.EntityFrameworkCore;

    using System.Threading;
    using System.Threading.Tasks;

    public class CarRentContext : DbContext, IUnitOfWork
    {
        public CarRentContext(DbContextOptions options)
            : base(options)
        {
        }

        public Task<int> CommitChangesAsync(CancellationToken cancellationToken = default)
        {
            return SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            modelBuilder.ApplyConfiguration(new CarConfiguration());
        }
    }
}
