using CollNextGuess.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace CollNextGuess.Infrastructure.Dal.PostgresSql.Repositories.GenericRepo.Read
{
    public class ReadGenericRepository<T> : IReadGenericRepository<T> where T : class, IEntity
    {
        private readonly DataContext _context;

        public ReadGenericRepository(DataContext context)
        {
            this._context = context;
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await _context.Set<T>().AnyAsync(entity => entity.Id.Equals(id));
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>().AsNoTracking();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().AsNoTracking().FirstOrDefaultAsync(entity => entity.Id.Equals(id));
        }

        public async Task<int> GetCountAsync()
        {
            return await (_context.Set<T>().AsNoTracking().CountAsync());
        }
    }
}
