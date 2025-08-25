namespace CarRent.Infrastructure.Persistence
{
    using CarRent.Domain.Primitives;

    using Mediator;

    using Microsoft.EntityFrameworkCore.Diagnostics;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    public class DispatchDomainEventsSaveChangesInterceptor : SaveChangesInterceptor
    {
        private readonly IPublisher _publisher;

        public DispatchDomainEventsSaveChangesInterceptor(IPublisher publisher)
        {
            _publisher = publisher;
        }

        public async override ValueTask<InterceptionResult<int>> SavingChangesAsync(DbContextEventData eventData, InterceptionResult<int> result, CancellationToken cancellationToken = default)
        {
            if (eventData.Context is not null)
            {
                var entities = eventData.Context.ChangeTracker
                    .Entries<Entity>()
                    .Where(e => e.Entity.DomainEvents.Any())
                    .Select(e => e.Entity)
                    .ToList();

                var domainEvents = entities
                    .SelectMany(e => e.DomainEvents)
                    .ToList();

                foreach (var domainEvent in domainEvents)
                {
                    await _publisher.Publish(domainEvent);
                }
            }

            return await base.SavingChangesAsync(eventData, result, cancellationToken);
        }
    }
}
