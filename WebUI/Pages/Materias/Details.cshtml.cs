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


namespace WebUI.Pages.Materias
{
    public class DetailsModel : PageModel
    {

        public Materia Materia { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var materia = await MateriasApiClient.GetAsync((int)id);
            if (materia == null)
            {
                return NotFound();
            }
            else
            {
                Materia = materia;
            }
            return Page();
        }
    }
}
