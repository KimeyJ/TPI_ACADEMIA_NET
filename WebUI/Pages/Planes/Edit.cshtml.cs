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

namespace WebUI.Pages.Planes
{
    public class EditModel : PageModel
    {

        [BindProperty]
        public Plan Plan { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plan =  await PlanesApiClient.GetAsync((int)id);
            if (plan == null)
            {
                return NotFound();
            }
            Plan = plan;
           ViewData["IdEsp"] = new SelectList(await EspecialidadesApiClient.GetAllAsync(), "EspecialidadId", "Descripcion");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            await PlanesApiClient.UpdateAsync(Plan);

            return RedirectToPage("./Index");
        }

    }
}
