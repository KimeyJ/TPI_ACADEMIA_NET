using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace form_main.APIs
{
    public class UsuariosApiClient
    {
        private static HttpClient client = new HttpClient();
        static UsuariosApiClient()
        {
            client.BaseAddress = new Uri("http://localhost:5093/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<Usuario> GetAsync(int id)
        {
            Usuario usuario = null;
            HttpResponseMessage response = await client.GetAsync("usuarios/" + id);
            if (response.IsSuccessStatusCode)
            {
                usuario = await response.Content.ReadAsAsync<Usuario>();
            }
            return usuario;
        }

        public static async Task<int> GetCountAsync()
        {
            int count = 0;
            HttpResponseMessage response = await client.GetAsync("usuarios/count");
            if (response.IsSuccessStatusCode)
            {
                count = await response.Content.ReadAsAsync<int>();
            }
            return count;
        }

        public static async Task<IEnumerable<Usuario>> GetAllAsync()
        {
            IEnumerable<Usuario> usuarios = null;
            HttpResponseMessage response = await client.GetAsync("usuarios");
            if (response.IsSuccessStatusCode)
            {
                usuarios = await response.Content.ReadAsAsync<IEnumerable<Usuario>>();
            }
            return usuarios;
        }
        public async static Task AddAsync(Usuario usuario)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("usuarios", usuario);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("usuarios/" + id);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(Usuario usuario)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync("usuarios", usuario);
            response.EnsureSuccessStatusCode();
        }

        public static async Task<Usuario> AuthenticateAsync(Usuario usuario)
        {
            Usuario rta = new Usuario();
            HttpResponseMessage response = await client.PostAsJsonAsync("usuarios/login", usuario);
            if (response.IsSuccessStatusCode)
            {
                rta = await response.Content.ReadAsAsync<Usuario>();
            }
            else { rta = null; }
            return rta;
        }

        public static async Task<bool> CheckDuplicateAsync(string usr, int id)
        {
            HttpResponseMessage response = await client.GetAsync("usuarios/check/" + usr + "/" + id);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<bool>();
            }
            return true;
        }
    }

}
