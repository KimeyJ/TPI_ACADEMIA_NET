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

namespace WebUI.Pages.Personas
{
    public class EditModel : PageModel
    {

        [BindProperty]
        public Persona Persona { get; set; } = default!;
        [BindProperty]
        public string Tipos { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var persona =  await PersonasApiClient.GetAsync((int)id);
            if (persona == null)
            {
                return NotFound();
            }
            ViewData["IdPlan"] = new SelectList(await PlanesApiClient.GetAllAsync(0), "PlanId", "Descripcion");
            Persona = persona;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            Persona.Tipo_persona = Convert.ToInt32(Tipos);
            await PersonasApiClient.UpdateAsync(Persona);
            return RedirectToPage("./Index");
        }
    }
}
