﻿using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace form_main.WindowsForm
{
    public class CursosApiClient
    {
        private static HttpClient client = new HttpClient();
        static CursosApiClient()
        {
            client.BaseAddress = new Uri("http://localhost:5093/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<Curso> GetAsync(int id)
        {
            Curso curso = null;
            HttpResponseMessage response = await client.GetAsync("cursos/" + id);
            if (response.IsSuccessStatusCode)
            {
                curso = await response.Content.ReadAsAsync<Curso>();
            }
            return curso;
        }

        public static async Task<IEnumerable<Curso>> GetAllAsync(int m_id, int c_id)
        {
            IEnumerable<Curso> cursos = null;
            HttpResponseMessage response = await client.GetAsync("cursos/all/" + m_id + "/" + c_id);
            if (response.IsSuccessStatusCode)
            {
                cursos = await response.Content.ReadAsAsync<IEnumerable<Curso>>();
            }
            return cursos;
        }
        public async static Task AddAsync(Curso curso)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("cursos", curso);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("cursos/" + id);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(Curso curso)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync("cursos", curso);
            response.EnsureSuccessStatusCode();
        }
    }

}
