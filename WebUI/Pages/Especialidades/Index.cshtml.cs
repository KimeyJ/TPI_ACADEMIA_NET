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

namespace WebUI.Pages.Especialidades
{
    public class IndexModel : PageModel
    {
       /* private readonly Domain.AcademiaContext _context;

        public IndexModel(Domain.AcademiaContext context)
        {
            _context = context;
        }*/

        public IList<Especialidad> Especialidad { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Especialidad = (IList<Especialidad>)await EspecialidadesApiClient.GetAllAsync();
        }
    }
}
