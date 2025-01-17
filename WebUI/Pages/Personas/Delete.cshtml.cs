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

namespace WebUI.Pages.Personas
{
    public class DeleteModel : PageModel
    {

        [BindProperty]
        public Persona Persona { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var persona = await PersonasApiClient.GetAsync((int)id);

            if (persona == null)
            {
                return NotFound();
            }
            else
            {
                Persona = persona;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var persona = await PersonasApiClient.GetAsync((int)id);
            if (persona != null)
            {
                Persona = persona;
                await PersonasApiClient.DeleteAsync(persona.Legajo);
            }

            return RedirectToPage("./Index");
        }
    }
}
