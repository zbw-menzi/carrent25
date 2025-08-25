namespace CarRent.Application.Cars
{
    using CarRent.Domain.Cars;

    using Mediator;

    using System.Threading;
    using System.Threading.Tasks;

    public class CarCreatedDomainEventHandler : INotificationHandler<CarCreatedDomainEvent>
    {
        private readonly IExternalCarLockingSystem _externalCarLockingSystem;

        public CarCreatedDomainEventHandler(IExternalCarLockingSystem externalCarLockingSystem)
        {
            _externalCarLockingSystem = externalCarLockingSystem;
        }

        public ValueTask Handle(CarCreatedDomainEvent notification, CancellationToken cancellationToken)
        {
            // Here is the code, what should happend if this event is raised
            _externalCarLockingSystem.DoWeirdStuff();

            return ValueTask.CompletedTask;
        }
    }
}
