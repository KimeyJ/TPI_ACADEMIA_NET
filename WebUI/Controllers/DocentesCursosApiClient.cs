using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class DocentesCursosApiClient
    {
        private static HttpClient client = new HttpClient();
        static DocentesCursosApiClient()
        {
            client.BaseAddress = new Uri("http://localhost:5093/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<Docente_Curso> GetAsync(int id)
        {
            Docente_Curso docente_curso = null;
            HttpResponseMessage response = await client.GetAsync("docente_cursos/" + id);
            if (response.IsSuccessStatusCode)
            {
                docente_curso = await response.Content.ReadAsAsync<Docente_Curso>();
            }
            return docente_curso;
        }

        public static async Task<IEnumerable<Docente_Curso>> GetAllAsync(int id, bool tp)
        {
            IEnumerable<Docente_Curso> docente_cursos = null;
            HttpResponseMessage response = await client.GetAsync("docente_cursos/group/" + id + "/" + tp);
            if (response.IsSuccessStatusCode)
            {
                docente_cursos = await response.Content.ReadAsAsync<IEnumerable<Docente_Curso>>();
            }
            return docente_cursos;
        }

        public async static Task<int> AddAsync(Docente_Curso docente_curso)
        {
            int id = 0;
            HttpResponseMessage response = await client.PostAsJsonAsync("docente_cursos", docente_curso);
            if (response.IsSuccessStatusCode)
            {
                id = await response.Content.ReadAsAsync<int>();
            }
            return id;
        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("docente_cursos/" + id);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(Docente_Curso docente_curso)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync("docente_cursos", docente_curso);
            response.EnsureSuccessStatusCode();
        }
    }

}
