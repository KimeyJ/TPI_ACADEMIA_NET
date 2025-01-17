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


namespace WebUI.Pages.Materias
{
    public class DeleteModel : PageModel
    {

        [BindProperty]
        public Materia Materia { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var materia = await MateriasApiClient.GetAsync((int)id);

            if (materia == null)
            {
                return NotFound();
            }
            else
            {
                Materia = materia;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var materia = await MateriasApiClient.GetAsync((int)id);
            if (materia != null)
            {
                Materia = materia;
                await MateriasApiClient.DeleteAsync(Materia.MateriaId, Materia.IdPlan);
            }

            return RedirectToPage("./Index");
        }
    }
}
