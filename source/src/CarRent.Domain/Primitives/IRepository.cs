namespace CarRent.Domain.Primitives
{
    public interface IRepository<T>
        where T : IAggregateRoot
    {
        T GetById(Guid id);

        void Add(T entity);

        void Remove(T entity);
    }
}
