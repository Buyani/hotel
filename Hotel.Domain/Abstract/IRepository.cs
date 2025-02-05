

namespace Hotel.Domain.Abstract
{
    public interface IRepository <TEntity> where TEntity : class
    {
        Task AddAsync(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        List<TEntity> GetAll();
        Task<TEntity> GetByIdAsync(int id);  
    }
}
