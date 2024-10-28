using Domain.Models;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace WindowsForms.Inscripcion_Folder
{
    public class InscripcionApiClient
    {
        private static HttpClient client = new HttpClient();
        static InscripcionApiClient()
        {
            client.BaseAddress = new Uri("http://localhost:5003/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public static async Task<Inscripcion> GetAsync(int id)
        {
            Inscripcion entity = null;
            HttpResponseMessage response = await client.GetAsync("inscripciones/" + id);
            if (response.IsSuccessStatusCode)
            {
                entity = await response.Content.ReadAsAsync<Inscripcion>();
            }
            return entity;
        }

        public static async Task<IEnumerable<Inscripcion>> GetAllAsync()
        {
            IEnumerable<Inscripcion> entities = null;
            HttpResponseMessage response = await client.GetAsync("inscripciones");
            if (response.IsSuccessStatusCode)
            {
                entities = await response.Content.ReadAsAsync<IEnumerable<Inscripcion>>();
            }
            return entities;
        }

        public static async Task AddAsync(Inscripcion entity)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("inscripciones", entity);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("inscripciones/" + id);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(Inscripcion entity)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync("inscripciones", entity);
            response.EnsureSuccessStatusCode();
        }
    }
}
