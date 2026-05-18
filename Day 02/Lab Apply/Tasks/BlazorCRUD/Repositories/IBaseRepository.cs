using System.Linq.Expressions;

namespace BlazorCRUD.Repositories
{
    public interface IBaseRepository<T>
    {
        public Task<List<T>> GetAllAsync();
        public Task<T?> GetByKeyAsync<TKey>(TKey id);
        public Task AddAsync(T entity);
        public Task UpdateAsync(T entity);
        public Task DeleteAsync<TKey>(TKey id);
    }
}
