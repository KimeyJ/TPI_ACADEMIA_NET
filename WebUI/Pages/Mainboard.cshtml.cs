using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Domain.Model;
using WebUI.Controllers;

namespace WebUI.Pages
{
    public class MainboardModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }
        public Persona persona { get; set; } = default!;
        public async void OnGet()
        {
            persona = await PersonasApiClient.GetAsync(Id);
        }
    }
}
