using System.Linq.Expressions;
using System.Net.Http.Json;

namespace BlazorCRUD.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T>
    {
        private readonly HttpClient _httpClient;

        public BaseRepository(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<T>>($"api/{typeof(T).Name}s");
        }

        public async Task<T?> GetByKeyAsync<TKey>(TKey id)
        {
            return await _httpClient.GetFromJsonAsync<T>($"api/{typeof(T).Name}s/{id}");
        }

        public async Task AddAsync(T entity)
        {
            await _httpClient.PostAsJsonAsync($"api/{typeof(T).Name}s", entity);
        }

        public async Task UpdateAsync(T entity)
        {
            await _httpClient.PutAsJsonAsync($"api/{typeof(T).Name}s", entity);
        }

        public async Task DeleteAsync<TKey>(TKey id)
        {
            await _httpClient.DeleteAsync($"api/{typeof(T).Name}s/{id}");
        }
    }
}
