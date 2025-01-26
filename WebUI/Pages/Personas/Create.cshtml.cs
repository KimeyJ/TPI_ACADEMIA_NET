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

namespace WebUI.Pages.Personas
{
    public class CreateModel : PageModel
    {
        public async Task<IActionResult> OnGetAsync()
        {
            ViewData["IdPlan"] = new SelectList(await PlanesApiClient.GetAllAsync(0), "PlanId", "Descripcion");
            return Page();
        }

        [BindProperty]
        public Persona Persona { get; set; } = default!;
        [BindProperty]
        public string Tipo {  get; set; }

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            Persona.Tipo_persona = Convert.ToInt32(Tipo);
            await PersonasApiClient.AddAsync(Persona);

            return RedirectToPage("./Index");
        }
    }
}
