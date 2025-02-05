

namespace Hotel.Domain.Abstract
{
    public interface IUnitOfWork :IDisposable
    {
        IRepository<TEntity> GetRepository<TEntity>() where TEntity : class;
        Task SaveChangesAsync();
    }
}
