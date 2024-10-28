using Domain.Models;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace WindowsForms.Materia_Folder
{
    public class MateriaApiClient
    {
        private static HttpClient client = new HttpClient();
        static MateriaApiClient()
        {
            client.BaseAddress = new Uri("http://localhost:5003/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public static async Task<Materia> GetAsync(int id)
        {
            Materia entity = null;
            HttpResponseMessage response = await client.GetAsync("materias/" + id);
            if (response.IsSuccessStatusCode)
            {
                entity = await response.Content.ReadAsAsync<Materia>();
            }
            return entity;
        }

        public static async Task<IEnumerable<Materia>> GetAllAsync()
        {
            IEnumerable<Materia> entities = null;
            HttpResponseMessage response = await client.GetAsync("materias");
            if (response.IsSuccessStatusCode)
            {
                entities = await response.Content.ReadAsAsync<IEnumerable<Materia>>();
            }
            return entities;
        }

        public static async Task AddAsync(Materia entity)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("materias", entity);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("materias/" + id);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(Materia entity)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync("materias", entity);
            response.EnsureSuccessStatusCode();
        }
    }
}
