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
    public class DetailsModel : PageModel
    {
        /*private readonly Domain.AcademiaContext _context;

        public DetailsModel(Domain.AcademiaContext context)
        {
            _context = context;
        }*/

        public Especialidad Especialidad { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var especialidad = await EspecialidadesApiClient.GetAsync((int)id);
            if (especialidad == null)
            {
                return NotFound();
            }
            else
            {
                Especialidad = especialidad;
            }
            return Page();
        }
    }
}
