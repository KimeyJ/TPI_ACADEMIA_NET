using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Domain;
using Domain.Model;
using WebUI.Controllers;

namespace WebUI.Pages.Usuarios
{
    public class IndexModel : PageModel
    {
        public string filterString;
        public int idPersona;
        public IList<Usuario> Usuario { get;set; } = default!;

        public async Task OnGetAsync(string filter, string id)
        {
            filterString = filter;
            idPersona = Convert.ToInt32(id);
            Usuario = (IList<Usuario>)await UsuariosApiClient.GetAllAsync();
            foreach (var usuario in Usuario)
            {
                usuario.Persona = await PersonasApiClient.GetAsync(usuario.IdPersona);
            }
        }
    }
}
