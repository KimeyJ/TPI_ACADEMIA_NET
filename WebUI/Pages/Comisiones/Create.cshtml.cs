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

namespace WebUI.Pages.Comisiones
{
    public class CreateModel : PageModel
    {
        IEnumerable<Comision> comisiones;
        IEnumerable<Plan> planes;
        public async void GetPlanes()
        {
            planes = await PlanesApiClient.GetAllAsync(0);
        }
        public IActionResult OnGet()
        {
            GetPlanes();
        ViewData["IdPlan"] = new SelectList(planes, "PlanId", "Descripcion");
            return Page();
        }

        [BindProperty]
        public Comision Comision { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await ComisionesApiClient.AddAsync(Comision);

            return RedirectToPage("./Index");
        }
    }
}
