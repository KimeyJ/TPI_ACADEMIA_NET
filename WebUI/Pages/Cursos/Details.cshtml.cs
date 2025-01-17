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

namespace WebUI.Pages.Cursos
{
    public class DetailsModel : PageModel
    {

        public Curso Curso { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var curso = await CursosApiClient.GetAsync((int)id);
            if (curso == null)
            {
                return NotFound();
            }
            else
            {
                Curso = curso;
            }
            return Page();
        }
    }
}
