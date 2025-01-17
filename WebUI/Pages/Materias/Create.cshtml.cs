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


namespace WebUI.Pages.Materias
{
    public class CreateModel : PageModel
    {
        IEnumerable<Plan> planes;

        public async void GetPlanes()
        {
            planes = await PlanesApiClient.GetAllAsync(0);
        }

        public IActionResult OnGet()
        {
        ViewData["IdPlan"] = new SelectList(planes, "PlanId", "Descripcion");
            return Page();
        }

        [BindProperty]
        public Materia Materia { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            await MateriasApiClient.AddAsync(Materia);

            return RedirectToPage("./Index");
        }
    }
}
