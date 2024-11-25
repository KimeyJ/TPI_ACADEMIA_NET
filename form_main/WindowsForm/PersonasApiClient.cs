using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace form_main.WindowsForm
{
    public class PersonasApiClient
    {
        private static HttpClient client = new HttpClient();
        static PersonasApiClient()
        {
            client.BaseAddress = new Uri("http://localhost:5093/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<Persona> GetAsync(int id)
        {
            Persona persona = null;
            HttpResponseMessage response = await client.GetAsync("personas/" + id);
            if (response.IsSuccessStatusCode)
            {
                persona = await response.Content.ReadAsAsync<Persona>();
            }
            return persona;
        }

        public static async Task<IEnumerable<Persona>> GetAllAsync(int tp)
        {
            IEnumerable<Persona> personas = null;
            HttpResponseMessage response = await client.GetAsync("personas/consulta/" + tp);
            if (response.IsSuccessStatusCode)
            {
                personas = await response.Content.ReadAsAsync<IEnumerable<Persona>>();
            }
            return personas;
        }
        public async static Task<int> AddAsync(Persona persona)
        {
            int id = 0;
            HttpResponseMessage response = await client.PostAsJsonAsync("personas", persona);
            if (response.IsSuccessStatusCode)
            {
                id = await response.Content.ReadAsAsync<int>();
            }
            return id;
        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("personas/" + id);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(Persona persona)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync("personas", persona);
            response.EnsureSuccessStatusCode();
        }
    }

}
