using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Domain;
using Domain.Model;
using WebUI.Controllers;

namespace WebUI.Pages.Inscripciones
{
    public class CreateModel : PageModel
    {

        public async Task<IActionResult> OnGet()
        {
        ViewData["IdAlumno"] = new SelectList(await PersonasApiClient.GetAllAsync(1), "Legajo", "Apellido");
        ViewData["IdAlumno"] = new SelectList(await CursosApiClient.GetAllAsync(0, 0), "CursoId", "Descripcion");
            return Page();
        }

        [BindProperty]
        public Inscripcion Inscripcion { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            await InscripcionesApiClient.AddAsync(Inscripcion);

            return RedirectToPage("./Index");
        }
    }
}
