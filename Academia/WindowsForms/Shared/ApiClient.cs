using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace WindowsForms.Shared
{
    public abstract class ApiClient<T>
    {
        private static HttpClient client = new HttpClient();
        private static string entityUrl { get; set; }

        public ApiClient()
        {
            client.BaseAddress = new Uri("https://localhost:7028/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<T> GetAsync(int id)
        {
            T entity = default(T);
            HttpResponseMessage response = await client.GetAsync(entityUrl + "/" + id);
            if (response.IsSuccessStatusCode)
            {
                entity = await response.Content.ReadAsAsync<T>();
            }
            return entity;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            IEnumerable<T> entities = null;
            HttpResponseMessage response = await client.GetAsync(entityUrl + "");
            if (response.IsSuccessStatusCode)
            {
                entities = await response.Content.ReadAsAsync<IEnumerable<T>>();
            }
            return entities;
        }

        public async Task AddAsync(T entity)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(entityUrl + "", entity);
            response.EnsureSuccessStatusCode();
        }

        public async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync(entityUrl + "/" + id);
            response.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(T entity)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync(entityUrl + "", entity);
            response.EnsureSuccessStatusCode();
        }
    }
}
