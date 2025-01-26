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
    public class DetailsModel : PageModel
    {
        public Plan Plan { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plan = await PlanesApiClient.GetAsync((int)id);
            plan.Especialidad = await EspecialidadesApiClient.GetAsync(plan.IdEsp);
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
    }
}
