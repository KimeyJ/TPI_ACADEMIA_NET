using Domain.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebUI.Controllers;

namespace WebUI.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public Usuario Usuario { get; set; } = default!;
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync()
        {
            var buffer = await UsuariosApiClient.AuthenticateAsync(Usuario);
            if(buffer == null)
            {
                return NotFound();
            }
            else
            {
                return RedirectToPage("Mainboard",new {id = buffer.IdPersona });
            }
            
        }
    }
}
