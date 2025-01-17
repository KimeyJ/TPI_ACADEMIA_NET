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

namespace WebUI.Pages.Especialidades
{
    public class EditModel : PageModel
    {
        /*private readonly Domain.AcademiaContext _context;

        public EditModel(Domain.AcademiaContext context)
        {
            _context = context;
        }*/

        [BindProperty]
        public Especialidad Especialidad { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var especialidad = await EspecialidadesApiClient.GetAsync((int)id);
            if (especialidad == null)
            {
                return NotFound();
            }
            Especialidad = especialidad;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            /*if (!ModelState.IsValid)
            {
                return Page();
            }*/

            try
            {
                await EspecialidadesApiClient.UpdateAsync(Especialidad);
            }
            catch (Exception e)
            {
                var especialidad = await EspecialidadesApiClient.GetAsync(Especialidad.EspecialidadId);
                if (especialidad == null)
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }
    }
}
