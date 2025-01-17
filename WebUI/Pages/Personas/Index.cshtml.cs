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

namespace WebUI.Pages.Personas
{
    public class IndexModel : PageModel
    {

        public IList<Persona> Persona { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Persona = (IList<Persona>)await PersonasApiClient.GetAllAsync(0);
        }
    }
}
