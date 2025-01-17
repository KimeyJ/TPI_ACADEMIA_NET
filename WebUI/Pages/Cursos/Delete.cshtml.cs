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

namespace WebUI.Pages.Cursos
{
    public class DeleteModel : PageModel
    {

        [BindProperty]
        public Curso Curso { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var curso = await CursosApiClient.GetAsync((int)id);

            if (curso == null)
            {
                return NotFound();
            }
            else
            {
                Curso = curso;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var curso = await CursosApiClient.GetAsync((int)id);
            if (curso != null)
            {
                Curso = curso;
                await CursosApiClient.DeleteAsync(Curso.CursoId);
            }

            return RedirectToPage("./Index");
        }
    }
}
