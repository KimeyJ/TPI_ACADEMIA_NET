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

namespace WebUI.Pages.Planes
{
    public class DeleteModel : PageModel
    {

        [BindProperty]
        public Plan Plan { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plan = await PlanesApiClient.GetAsync((int)id);

            if (plan == null)
            {
                return NotFound();
            }
            else
            {
                Plan = plan;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plan = await PlanesApiClient.GetAsync((int)id);
            if (plan != null)
            {
                Plan = plan;
                await PlanesApiClient.DeleteAsync(plan.PlanId);
            }

            return RedirectToPage("./Index");
        }
    }
}
