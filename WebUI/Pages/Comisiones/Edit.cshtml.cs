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

namespace WebUI.Pages.Comisiones
{
    public class EditModel : PageModel
    {

        [BindProperty]
        public Comision Comision { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comision = await ComisionesApiClient.GetAsync((int)id);
            if (comision == null)
            {
                return NotFound();
            }
            Comision = comision;
           ViewData["IdPlan"] = new SelectList(await PlanesApiClient.GetAllAsync(0), "PlanId", "Descripcion");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            await ComisionesApiClient.UpdateAsync(Comision);

            return RedirectToPage("./Index");
        }
    }
}
