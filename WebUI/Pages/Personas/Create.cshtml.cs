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

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Persona Persona { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {

            await PersonasApiClient.AddAsync(Persona);

            return RedirectToPage("./Index");
        }
    }
}
