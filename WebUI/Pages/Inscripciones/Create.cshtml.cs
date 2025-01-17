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
        IEnumerable<Persona> alumnos;
        IEnumerable<Curso> cursos;

        public async void GetAlCur()
        {
            alumnos = await PersonasApiClient.GetAllAsync(1);
            cursos = await CursosApiClient.GetAllAsync(0, 0);
        }

        public IActionResult OnGet()
        {
        ViewData["IdAlumno"] = new SelectList(alumnos, "Legajo", "Apellido");
        ViewData["IdAlumno"] = new SelectList(cursos, "CursoId", "Descripcion");
            return Page();
        }

        [BindProperty]
        public Inscripcion Inscripcion { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await InscripcionesApiClient.AddAsync(Inscripcion);

            return RedirectToPage("./Index");
        }
    }
}
