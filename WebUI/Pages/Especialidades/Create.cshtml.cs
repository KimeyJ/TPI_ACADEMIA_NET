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

namespace WebUI.Pages.Especialidades
{
    public class CreateModel : PageModel
    {
       /* private readonly Domain.AcademiaContext _context;

        public CreateModel(Domain.AcademiaContext context)
        {
            _context = context;
        }*/

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Especialidad Especialidad { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            /*if (!ModelState.IsValid)
            {
                return Page();
            }*/

            await EspecialidadesApiClient.AddAsync(Especialidad);

            return RedirectToPage("./Index");
        }
    }
}
