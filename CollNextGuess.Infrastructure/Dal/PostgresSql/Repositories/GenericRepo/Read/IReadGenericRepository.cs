namespace CollNextGuess.Infrastructure.Dal.PostgresSql.Repositories.GenericRepo.Read
{
    public interface IReadGenericRepository<T> where T : class
    {
        Task<int> GetCountAsync();

        IQueryable<T> GetAll();

        Task<T> GetByIdAsync(int id);

        Task<bool> ExistsAsync(int id);
    }
}
