using WebUI.Controllers;
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

namespace WebUI.Pages.Inscripciones
{
    public class EditModel : PageModel
    {

        [BindProperty]
        public Inscripcion Inscripcion { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inscripcion =  await InscripcionesApiClient.GetAsync((int)id);
            if (inscripcion == null)
            {
                return NotFound();
            }
            Inscripcion = inscripcion;
           ViewData["IdAlumno"] = new SelectList(await PersonasApiClient.GetAllAsync(1), "Legajo", "Apellido");
           ViewData["IdAlumno"] = new SelectList(await CursosApiClient.GetAllAsync(0,0), "CursoId", "Descripcion");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            await InscripcionesApiClient.UpdateAsync(Inscripcion);

            return RedirectToPage("./Index");
        }
    }
}
