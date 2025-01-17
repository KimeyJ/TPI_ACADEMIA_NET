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
        IEnumerable<Especialidad> especialidades;

        public async void GetEsp()
        {
            especialidades = await EspecialidadesApiClient.GetAllAsync();
        }

        public IActionResult OnGet()
        {
        ViewData["IdEsp"] = new SelectList(especialidades, "EspecialidadId", "Descripcion");
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
