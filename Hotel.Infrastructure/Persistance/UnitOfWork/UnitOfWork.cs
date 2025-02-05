using Hotel.Domain.Abstract;
using Hotel.Infrastructure.Persistance.Repositories;

namespace Hotel.Infrastructure.Persistance.UnitOfWork
{
    public class UnitOfWork(HotelContext context) : IUnitOfWork
    {
        private readonly HotelContext _context = context;
        private readonly Dictionary<Type, object> _repositories = [];

        public void Dispose() => 
            _context.Dispose();

        public IRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            if (_repositories.ContainsKey(typeof(TEntity)))
            {
                return (IRepository<TEntity>)_repositories[typeof(TEntity)];
            }

            var repository = new Repository<TEntity>(_context);
            _repositories.Add(typeof(TEntity), repository);
            return repository;
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
