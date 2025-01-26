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

namespace WebUI.Pages.Comisiones
{
    public class DetailsModel : PageModel
    {

        public Comision Comision { get; set; } = default!;
        public Plan plan { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comision = await ComisionesApiClient.GetAsync((int)id);
            comision.Plan = await PlanesApiClient.GetAsync(comision.IdPlan);

            if (comision == null)
            {
                return NotFound();
            }
            else
            {
                Comision = comision;
            }
            return Page();
        }
    }
}
