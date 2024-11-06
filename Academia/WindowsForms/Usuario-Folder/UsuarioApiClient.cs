using Domain.Models;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace WindowsForms
{
    public class UsuarioApiClient
    {
        private static HttpClient client = new HttpClient();
        static UsuarioApiClient()
        {
            client.BaseAddress = new Uri("http://localhost:5003/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<Usuario> GetAsync(int id)
        {
            Usuario entity = null;
            HttpResponseMessage response = await client.GetAsync("usuarios/" + id);
            if (response.IsSuccessStatusCode)
            {
                entity = await response.Content.ReadAsAsync<Usuario>();
            }
            return entity;
        }

        public static async Task<IEnumerable<Usuario>> GetAllDocentesAsync()
        {
            IEnumerable<Usuario> entities = null;
            HttpResponseMessage response = await client.GetAsync("docentes");
            if (response.IsSuccessStatusCode)
            {
                entities = await response.Content.ReadAsAsync<IEnumerable<Usuario>>();
            }
            return entities;
        }

        public static async Task<IEnumerable<Usuario>> GetAllAlumnosAsync()
        {
            IEnumerable<Usuario> entities = null;
            HttpResponseMessage response = await client.GetAsync("alumnos");
            if (response.IsSuccessStatusCode)
            {
                entities = await response.Content.ReadAsAsync<IEnumerable<Usuario>>();
            }
            return entities;
        }

        public static async Task<IEnumerable<Usuario>> GetAllAsync()
        {
            IEnumerable<Usuario> entities = null;
            HttpResponseMessage response = await client.GetAsync("usuarios");
            if (response.IsSuccessStatusCode)
            {
                entities = await response.Content.ReadAsAsync<IEnumerable<Usuario>>();
            }
            return entities;
        }

        public static async Task AddAsync(Usuario entity)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("usuarios", entity);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("usuarios/" + id);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(Usuario entity)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync("usuarios", entity);
            response.EnsureSuccessStatusCode();
        }

        public static async Task<Usuario> LoginAsync(string email, string clave)
        {
            Usuario entity = null;
            HttpResponseMessage response = await client.GetAsync("usuarios/login/" + email + "/" + clave);
            if (response.IsSuccessStatusCode)
            {
                entity = await response.Content.ReadAsAsync<Usuario>();
            }
            return entity;
        }

    }
}
