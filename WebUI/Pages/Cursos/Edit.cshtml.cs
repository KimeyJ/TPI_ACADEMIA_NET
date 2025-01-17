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

namespace WebUI.Pages.Cursos
{
    public class EditModel : PageModel
    {

        [BindProperty]
        public Curso Curso { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var curso =  await CursosApiClient.GetAsync((int)id);
            if (curso == null)
            {
                return NotFound();
            }
            Curso = curso;
           ViewData["IdComision"] = new SelectList(await ComisionesApiClient.GetAllAsync(0), "ComisionId", "Descripcion");
           ViewData["IdMateria"] = new SelectList(await MateriasApiClient.GetAllAsync(0), "MateriaId", "Descripcion");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            await CursosApiClient.UpdateAsync(Curso);

            return RedirectToPage("./Index");
        }
    }
}
