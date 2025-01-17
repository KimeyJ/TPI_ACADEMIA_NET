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

namespace WebUI.Pages.Usuarios
{
    public class EditModel : PageModel
    {

        [BindProperty]
        public Usuario Usuario { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await UsuariosApiClient.GetAsync((int)id);
            if (usuario == null)
            {
                return NotFound();
            }
            Usuario = usuario;
           ViewData["IdPersona"] = new SelectList(await PersonasApiClient.GetAllAsync(0), "Legajo", "Apellido");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            await UsuariosApiClient.UpdateAsync(Usuario);

            return RedirectToPage("./Index");
        }
    }
}
