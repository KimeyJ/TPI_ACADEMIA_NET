﻿using Domain.Model;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace form_main.APIs
{
    public class EspecialidadesApiClient
    {
        private static HttpClient client = new HttpClient();
        static EspecialidadesApiClient()
        {
            client.BaseAddress = new Uri("http://localhost:5093/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<Especialidad> GetAsync(int id)
        {
            Especialidad especialidad = null;
            HttpResponseMessage response = await client.GetAsync("especialidades/" + id);
            if (response.IsSuccessStatusCode)
            {
                especialidad = await response.Content.ReadAsAsync<Especialidad>();
            }
            return especialidad;
        }

        public static async Task<IEnumerable<Especialidad>> GetAllAsync()
        {
            IEnumerable<Especialidad> especialidades = null;
            HttpResponseMessage response = await client.GetAsync("especialidades");
            if (response.IsSuccessStatusCode)
            {
                especialidades = await response.Content.ReadAsAsync<IEnumerable<Especialidad>>();
            }
            return especialidades;
        }
        public async static Task AddAsync(Especialidad especialidad)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("especialidades", especialidad);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("especialidades/" + id);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(Especialidad especialidad)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync("especialidades", especialidad);
            response.EnsureSuccessStatusCode();
        }
    }
}
