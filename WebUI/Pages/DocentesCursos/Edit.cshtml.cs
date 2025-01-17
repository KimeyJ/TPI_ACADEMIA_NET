using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain;
using Domain.Model;
using WebUI.Controllers;

namespace WebUI.Pages.DocentesCursos
{
    public class EditModel : PageModel
    {

        [BindProperty]
        public Docente_Curso Docente_Curso { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var docente_curso =  await DocentesCursosApiClient.GetAsync((int)id);
            if (docente_curso == null)
            {
                return NotFound();
            }
            Docente_Curso = docente_curso;
           ViewData["IdCurso"] = new SelectList(await CursosApiClient.GetAllAsync(0,0), "CursoId", "Descripcion");
           ViewData["IdDocente"] = new SelectList(await PersonasApiClient.GetAllAsync(2), "Legajo", "Apellido");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            await DocentesCursosApiClient.UpdateAsync(Docente_Curso);

            return RedirectToPage("./Index");
        }
    }
}
