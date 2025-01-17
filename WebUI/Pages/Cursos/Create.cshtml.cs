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

namespace WebUI.Pages.Cursos
{
    public class CreateModel : PageModel
    {
        IEnumerable<Comision> comisiones;
        IEnumerable<Materia> materias;

        public async void GetComMat()
        {
            comisiones = await ComisionesApiClient.GetAllAsync(0);
            materias = await MateriasApiClient.GetAllAsync(0);
        }

        public IActionResult OnGet()
        {
            GetComMat();
        ViewData["IdComision"] = new SelectList(comisiones, "ComisionId", "Descripcion");
        ViewData["IdMateria"] = new SelectList(materias, "MateriaId", "Descripcion");
            return Page();
        }

        [BindProperty]
        public Curso Curso { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {

            await CursosApiClient.AddAsync(Curso);

            return RedirectToPage("./Index");
        }
    }
}
