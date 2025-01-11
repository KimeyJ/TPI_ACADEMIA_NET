using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace form_main.APIs
{
    public class MateriasApiClient
    {
        private static HttpClient client = new HttpClient();
        static MateriasApiClient()
        {
            client.BaseAddress = new Uri("http://localhost:5093/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<Materia> GetAsync(int id)
        {
            Materia materia = null;
            HttpResponseMessage response = await client.GetAsync("materias/" + id);
            if (response.IsSuccessStatusCode)
            {
                materia = await response.Content.ReadAsAsync<Materia>();
            }
            return materia;
        }

        public static async Task<IEnumerable<Materia>> GetAllAsync(int p_id)
        {
            IEnumerable<Materia> materias = null;
            HttpResponseMessage response = await client.GetAsync("materias/plan/" + p_id);
            if (response.IsSuccessStatusCode)
            {
                materias = await response.Content.ReadAsAsync<IEnumerable<Materia>>();
            }
            return materias;
        }
        public async static Task AddAsync(Materia materia)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("materias", materia);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(int id, int id_p)
        {
            HttpResponseMessage response = await client.DeleteAsync("materias/" + id + "/" + id_p);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(Materia materia)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync("materias", materia);
            response.EnsureSuccessStatusCode();
        }
    }

}
