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

namespace WebUI.Pages.Usuarios
{
    public class CreateModel : PageModel
    {
        IEnumerable<Persona> personas;

        public async void GetPersonas()
        {
            personas = await PersonasApiClient.GetAllAsync(0);
        }

        public IActionResult OnGet()
        {
        ViewData["IdPersona"] = new SelectList(personas, "Legajo", "Apellido");
            return Page();
        }

        [BindProperty]
        public Usuario Usuario { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await UsuariosApiClient.AddAsync(Usuario);

            return RedirectToPage("./Index");
        }
    }
}
