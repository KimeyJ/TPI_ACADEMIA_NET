using Domain.Model;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace WindowsForm
{
    public class ComisionesApiClient
    {
        private static HttpClient client = new HttpClient();
        static ComisionesApiClient()
        {
            client.BaseAddress = new Uri("http://localhost:5093/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<Comision> GetAsync(int id)
        {
            Comision comision = null;
            HttpResponseMessage response = await client.GetAsync("comisiones/"+id);
            if (response.IsSuccessStatusCode)
            {
                comision = await response.Content.ReadAsAsync<Comision>();
            }
            return comision;
        }

        public static async Task<IEnumerable<Comision>> GetAllAsync(int id)
        {
            IEnumerable<Comision> comisiones = null;
            HttpResponseMessage response = await client.GetAsync("comisiones/"+id);
            if (response.IsSuccessStatusCode)
            {
                comisiones = await response.Content.ReadAsAsync<IEnumerable<Comision>>();
            }
            return comisiones;
        }
        public async static Task AddAsync(Comision comision)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("comisiones", comision);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("comisiones/" + id);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(Comision comision)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync("comisiones", comision);
            response.EnsureSuccessStatusCode();
        }
    }
}
