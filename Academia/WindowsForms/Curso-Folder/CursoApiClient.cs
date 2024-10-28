using Domain.Models;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace WindowsForms.Curso_Folder
{
    public class CursoApiClient
    {
        private static HttpClient client = new HttpClient();
        static CursoApiClient()
        {
            client.BaseAddress = new Uri("http://localhost:5003/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public static async Task<Curso> GetAsync(int id)
        {
            Curso entity = null;
            HttpResponseMessage response = await client.GetAsync("cursos/" + id);
            if (response.IsSuccessStatusCode)
            {
                entity = await response.Content.ReadAsAsync<Curso>();
            }
            return entity;
        }

        public static async Task<IEnumerable<Curso>> GetAllAsync()
        {
            IEnumerable<Curso> entities = null;
            HttpResponseMessage response = await client.GetAsync("cursos");
            if (response.IsSuccessStatusCode)
            {
                entities = await response.Content.ReadAsAsync<IEnumerable<Curso>>();
            }
            return entities;
        }

        public static async Task AddAsync(Curso entity)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("cursos", entity);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("cursos/" + id);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(Curso entity)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync("cursos", entity);
            response.EnsureSuccessStatusCode();
        }
    }
}
