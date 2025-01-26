using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Domain.Model;
using WebUI.Controllers;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace WebUI.Pages
{
    public class MainboardModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }
        public Persona Persona { get; set; } = default!;
        public async Task<IActionResult> OnGetAsync()
        {
            Persona = await PersonasApiClient.GetAsync(Id);
            if (Persona == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }
    }
}
