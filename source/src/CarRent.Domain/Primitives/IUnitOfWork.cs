namespace CarRent.Domain.Primitives
{
    using System.Threading.Tasks;

    public interface IUnitOfWork
    {
        Task<int> CommitChangesAsync(CancellationToken cancellationToken = default);
    }
}
