using Domain.Models;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using WindowsForms.Shared;

namespace WindowsForms
{
    public class PersonaApiClient : ApiClient<Persona>
    {
        private static HttpClient client = new HttpClient();

        private static string entityUrl = "Personas";
    }
}
