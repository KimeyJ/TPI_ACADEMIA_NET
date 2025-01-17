using WebUI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Domain;
using Domain.Model;

namespace WebUI.Pages.Inscripciones
{
    public class DeleteModel : PageModel
    {

        [BindProperty]
        public Inscripcion Inscripcion { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inscripcion = await InscripcionesApiClient.GetAsync((int)id);

            if (inscripcion == null)
            {
                return NotFound();
            }
            else
            {
                Inscripcion = inscripcion;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inscripcion = await InscripcionesApiClient.GetAsync((int)id);
            if (inscripcion != null)
            {
                Inscripcion = inscripcion;
                await InscripcionesApiClient.DeleteAsync((int)id);
            }

            return RedirectToPage("./Index");
        }
    }
}
