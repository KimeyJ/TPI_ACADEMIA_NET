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

namespace WebUI.Pages.Planes
{
    public class CreateModel : PageModel
    {
        public async Task<IActionResult> OnGet()
        {
        ViewData["IdEsp"] = new SelectList(await EspecialidadesApiClient.GetAllAsync(), "EspecialidadId", "Descripcion");
            return Page();
        }

        [BindProperty]
        public Plan Plan { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            await PlanesApiClient.AddAsync(Plan);

            return RedirectToPage("./Index");
        }
    }
}
