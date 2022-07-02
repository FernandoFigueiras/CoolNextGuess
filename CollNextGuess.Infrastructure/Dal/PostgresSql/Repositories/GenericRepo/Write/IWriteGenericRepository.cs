using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollNextGuess.Infrastructure.Dal.PostgresSql.Repositories.GenericRepo.Write
{
    public interface IWriteGenericRepository<T> where T : class
    {
        Task InsertAsync(T entity);

        Task InsertRageAsync(IEnumerable<T> entities);

        Task UpdateAsync(T entity);

        Task UpdateRageAsync(IEnumerable<T> entities);

        Task DeleteAsync(T entity);

        Task DeleteByIdAsync(int id);

        Task DeleteRangeAsync(IEnumerable<T> entities);
    }
}
