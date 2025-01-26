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
using System.Web;

namespace WebUI.Pages.Personas
{
    public class IndexModel : PageModel
    {

        public int idFilter;
        public string apelFilter;
        public string dirFilter;
        public int planFilter;
        public int catFilter;
        public IList<Persona> Persona { get; set; } = default!;
        public IList<Plan> Plan { get; set; } = default!;
        public string[] tipos = ["Alumno", "Profesor", "Administrador"];
        public async Task OnGetAsync(string id, string apellido, string direccion, string categoria, string plan)
        {
            idFilter = Convert.ToInt32(id);
            apelFilter = apellido;
            dirFilter = direccion;
            planFilter = Convert.ToInt32(plan);
            catFilter = Convert.ToInt32(categoria);
            Persona = (IList<Persona>)await PersonasApiClient.GetAllAsync(catFilter);
            Plan = (IList<Plan>)await PlanesApiClient.GetAllAsync(0);
        }
    }
}
