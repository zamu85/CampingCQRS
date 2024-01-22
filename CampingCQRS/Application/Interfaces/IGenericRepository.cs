namespace Application.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> Entities { get; }

        Task<T> AddAsync(T entity);

        Task DeleteAsync(T entity);

        Task<List<T>> GetAllAsync();

        Task<T> GetByIdAsync(int id);

        Task UpdateAsync(T entity);
    }
}
