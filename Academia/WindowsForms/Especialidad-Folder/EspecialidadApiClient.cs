using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms.Especialidad_Folder
{
    public class EspecialidadApiClient
    {
        private static HttpClient client = new HttpClient();
        public static async Task<Especialidad> GetAsync(int id)
        {
            Especialidad entity = null;
            HttpResponseMessage response = await client.GetAsync("especialidades/" + id);
            if (response.IsSuccessStatusCode)
            {
                entity = await response.Content.ReadAsAsync<Especialidad>();
            }
            return entity;
        }

        public static async Task<IEnumerable<Especialidad>> GetAllAsync()
        {
            IEnumerable<Especialidad> entities = null;
            HttpResponseMessage response = await client.GetAsync("especialidades");
            if (response.IsSuccessStatusCode)
            {
                entities = await response.Content.ReadAsAsync<IEnumerable<Especialidad>>();
            }
            return entities;
        }

        public static async Task AddAsync(Especialidad entity)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("especialidades", entity);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("especialidades/" + id);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(Especialidad entity)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync("personas", entity);
            response.EnsureSuccessStatusCode();
        }
    }
}
