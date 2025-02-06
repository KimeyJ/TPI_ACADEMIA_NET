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

namespace WebUI.Pages.DocentesCursos
{
    public class DeleteModel : PageModel
    {

        [BindProperty]
        public Docente_Curso Docente_Curso { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var docente_curso = await DocentesCursosApiClient.GetAsync((int)id);

            if (docente_curso == null)
            {
                return NotFound();
            }
            else
            {
                Docente_Curso = docente_curso;
                Docente_Curso.Docente = await PersonasApiClient.GetAsync(Docente_Curso.IdDocente);
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var docente_curso = await DocentesCursosApiClient.GetAsync((int)id);
            if (docente_curso != null)
            {
                Docente_Curso = docente_curso;
                await DocentesCursosApiClient.DeleteAsync(Docente_Curso.Docente_CursoId);
            }

            return RedirectToPage("../AsignarProfesores", new { idcurso = Docente_Curso.IdCurso });
        }
    }
}
