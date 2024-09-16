using Domain.Models;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Numerics;
using WindowsForms.Shared;

namespace WindowsForms
{
    public class PlanApiClient
    {
        private static HttpClient client = new HttpClient();
        public static async Task<Plan> GetAsync(int id)
        {
            Plan entity = null;
            HttpResponseMessage response = await client.GetAsync("planes/" + id);
            if (response.IsSuccessStatusCode)
            {
                entity = await response.Content.ReadAsAsync<Plan>();
            }
            return entity;
        }

        public static async Task<IEnumerable<Plan>> GetAllAsync()
        {
            IEnumerable<Plan> entities = null;
            HttpResponseMessage response = await client.GetAsync("planes");
            if (response.IsSuccessStatusCode)
            {
                entities = await response.Content.ReadAsAsync<IEnumerable<Plan>>();
            }
            return entities;
        }

        public static async Task AddAsync(Plan entity)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("planes", entity);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("planes/" + id);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(Plan entity)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync("planes", entity);
            response.EnsureSuccessStatusCode();
        }
    }
}
