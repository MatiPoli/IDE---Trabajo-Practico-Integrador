using Domain.Models;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace WindowsForms.DocenteCurso_Folder
{
    public class DocenteCursoApiCliente
    {
        private static HttpClient client = new HttpClient();
        static DocenteCursoApiCliente()
        {
            client.BaseAddress = new Uri("http://localhost:5003/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public static async Task<Docente_Curso> GetAsync(int id)
        {
            Docente_Curso entity = null;
            HttpResponseMessage response = await client.GetAsync("docentes_cursos/" + id);
            if (response.IsSuccessStatusCode)
            {
                entity = await response.Content.ReadAsAsync<Docente_Curso>();
            }
            return entity;
        }

        public static async Task<IEnumerable<Docente_Curso>> GetAllAsync()
        {
            IEnumerable<Docente_Curso> entities = null;
            HttpResponseMessage response = await client.GetAsync("docentes_cursos");
            if (response.IsSuccessStatusCode)
            {
                entities = await response.Content.ReadAsAsync<IEnumerable<Docente_Curso>>();
            }
            return entities;
        }

        public static async Task AddAsync(Docente_Curso entity)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("docentes_cursos", entity);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("docentes_cursos/" + id);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(Docente_Curso entity)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync("docentes_cursos", entity);
            response.EnsureSuccessStatusCode();
        }
    }
}
