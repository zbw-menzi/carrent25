namespace CarRent.Infrastructure.Persistence
{
    using CarRent.Domain.Primitives;

    using System;

    public abstract class Repository<T> : IRepository<T>
        where T : class, IAggregateRoot
    {
        private readonly CarRentContext _context;

        protected Repository(CarRentContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Add(entity);
        }

        public T GetById(Guid id)
        {
            var entity = _context.Find<T>([id]);
            if (entity is null)
            {
                throw new InvalidOperationException();
            }

            return entity;
        }

        public void Remove(T entity)
        {
            _context.Remove(entity);
        }
    }
}
