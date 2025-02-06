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
        public async Task<IActionResult> OnGetAsync()
        {
        ViewData["IdComision"] = new SelectList(await ComisionesApiClient.GetAllAsync(0), "ComisionId", "Descripcion");
        ViewData["IdMateria"] = new SelectList(await MateriasApiClient.GetAllAsync(0), "MateriaId", "Descripcion");
            return Page();
        }

        [BindProperty]
        public Curso Curso { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {

            int id = await CursosApiClient.AddAsync(Curso);

            return RedirectToPage("../AsignarProfesores", new {idcurso=id});
        }
    }
}
