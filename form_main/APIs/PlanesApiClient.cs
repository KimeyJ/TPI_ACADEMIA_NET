using Domain.Model;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace form_main.APIs
{
    public class PlanesApiClient
    {
        private static HttpClient client = new HttpClient();
        static PlanesApiClient()
        {
            client.BaseAddress = new Uri("http://localhost:5093/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<Plan> GetAsync(int id)
        {
            Plan plan = null;
            HttpResponseMessage response = await client.GetAsync("planes/" + id);
            if (response.IsSuccessStatusCode)
            {
                plan = await response.Content.ReadAsAsync<Plan>();
            }
            return plan;
        }

        public static async Task<Plan> GetLastAsync(int id)
        {
            Plan plan = null;
            HttpResponseMessage response = await client.GetAsync("planes/last/" + id);
            if (response.IsSuccessStatusCode)
            {
                plan = await response.Content.ReadAsAsync<Plan>();
            }
            return plan;
        }

        public static async Task<IEnumerable<Plan>> GetAllAsync(int id)
        {
            IEnumerable<Plan> planes = null;
            HttpResponseMessage response = await client.GetAsync("planes/all/" + id);
            if (response.IsSuccessStatusCode)
            {
                planes = await response.Content.ReadAsAsync<IEnumerable<Plan>>();
            }
            return planes;
        }
        public async static Task AddAsync(Plan plan)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("planes", plan);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("planes/" + id);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(Plan plan)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync("planes", plan);
            response.EnsureSuccessStatusCode();
        }
    }
}
