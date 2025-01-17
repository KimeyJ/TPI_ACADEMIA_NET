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

namespace WebUI.Pages.Inscripciones
{
    public class IndexModel : PageModel
    {

        public IList<Inscripcion> Inscripcion { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Inscripcion = (IList<Inscripcion>)await InscripcionesApiClient.GetAllAsync(0,false);
        }
    }
}
