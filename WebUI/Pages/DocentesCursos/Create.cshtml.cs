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

namespace WebUI.Pages.DocentesCursos
{
    public class CreateModel : PageModel
    {
        public async Task<IActionResult> OnGet()
        {
        ViewData["IdCurso"] = new SelectList(await CursosApiClient.GetAllAsync(0, 0), "CursoId", "Descripcion");
        ViewData["IdDocente"] = new SelectList(await PersonasApiClient.GetAllAsync(2), "Legajo", "Apellido");
            return Page();
        }

        [BindProperty]
        public Docente_Curso Docente_Curso { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            await DocentesCursosApiClient.AddAsync(Docente_Curso);

            return RedirectToPage("./Index");
        }
    }
}
