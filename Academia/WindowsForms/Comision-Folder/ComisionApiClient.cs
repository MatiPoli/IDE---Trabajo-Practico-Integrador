using Domain.Models;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace WindowsForms.Comision_Folder
{
    public class ComisionApiClient
    {
        private static HttpClient client = new HttpClient();
        static ComisionApiClient()
        {
            client.BaseAddress = new Uri("http://localhost:5003/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public static async Task<Comision> GetAsync(int id)
        {
            Comision entity = null;
            HttpResponseMessage response = await client.GetAsync("comisiones/" + id);
            if (response.IsSuccessStatusCode)
            {
                entity = await response.Content.ReadAsAsync<Comision>();
            }
            return entity;
        }

        public static async Task<IEnumerable<Comision>> GetAllAsync()
        {
            IEnumerable<Comision> entities = null;
            HttpResponseMessage response = await client.GetAsync("comisiones");
            if (response.IsSuccessStatusCode)
            {
                entities = await response.Content.ReadAsAsync<IEnumerable<Comision>>();
            }
            return entities;
        }

        public static async Task AddAsync(Comision entity)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("comisiones", entity);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("comisiones/" + id);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(Comision entity)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync("comisiones", entity);
            response.EnsureSuccessStatusCode();
        }
    }
}
