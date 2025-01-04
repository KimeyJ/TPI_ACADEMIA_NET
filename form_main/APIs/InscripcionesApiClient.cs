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
    public class InscripcionesApiClient
    {
        private static HttpClient client = new HttpClient();
        static InscripcionesApiClient()
        {
            client.BaseAddress = new Uri("http://localhost:5093/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<Inscripcion> GetAsync(int id)
        {
            Inscripcion inscripcion = null;
            HttpResponseMessage response = await client.GetAsync("inscripciones/" + id);
            if (response.IsSuccessStatusCode)
            {
                inscripcion = await response.Content.ReadAsAsync<Inscripcion>();
            }
            return inscripcion;
        }

        public static async Task<IEnumerable<Inscripcion>> GetAllAsync(int id, bool t_id)
        {
            IEnumerable<Inscripcion> inscripciones = null;
            HttpResponseMessage response = await client.GetAsync("inscripciones/" + t_id + "/" + id);
            if (response.IsSuccessStatusCode)
            {
                inscripciones = await response.Content.ReadAsAsync<IEnumerable<Inscripcion>>();
            }
            return inscripciones;
        }
        public async static Task<int> AddAsync(Inscripcion inscripcion)
        {
            int id = 0;
            HttpResponseMessage response = await client.PostAsJsonAsync("inscripciones", inscripcion);
            if (response.IsSuccessStatusCode)
            {
                id = await response.Content.ReadAsAsync<int>();
            }
            return id;
        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("inscripciones/" + id);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(Inscripcion inscripcion)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync("inscripciones", inscripcion);
            response.EnsureSuccessStatusCode();
        }
    }
}
