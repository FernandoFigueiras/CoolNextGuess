using CollNextGuess.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace CollNextGuess.Infrastructure.Dal.PostgresSql.Repositories.GenericRepo.Write
{
    public class WriteGenericRepository<T> : IWriteGenericRepository<T> where T : class, IEntity
    {
        private readonly DataContext _context;

        public WriteGenericRepository(DataContext context)
        {
            _context = context;
        }

        public async Task DeleteAsync(T entity)
        {
            this._context.Set<T>().Remove(entity);
            await SaveAllAsync();
        }

        public async Task DeleteByIdAsync(int id)
        {
            T entityToDelete = await _context.Set<T>().FirstOrDefaultAsync(t => t.Id == id);
            if (entityToDelete != null)
            {
                this._context.Set<T>().Remove(entityToDelete);
                await SaveAllAsync();
            }
        }

        public async Task DeleteRangeAsync(IEnumerable<T> entities)
        {
            this._context.Set<T>().RemoveRange(entities);
            await SaveAllAsync();
        }

        public async Task InsertAsync(T entity)
        {
            await this._context.Set<T>().AddAsync(entity);
            await SaveAllAsync();
        }

        public async Task InsertRageAsync(IEnumerable<T> entities)
        {
            this._context.Set<T>().AddRange(entities);
            await SaveAllAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            this._context.Set<T>().Update(entity);
            await SaveAllAsync();
        }

        public async Task UpdateRageAsync(IEnumerable<T> entities)
        {
            this._context.Set<T>().UpdateRange(entities);
            await SaveAllAsync();
        }

        private async Task<bool> SaveAllAsync()
        {
            return await this._context.SaveChangesAsync() > 0;
        }
    }
}
