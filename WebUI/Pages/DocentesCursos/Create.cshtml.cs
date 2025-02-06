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

namespace WebUI.Pages.DocentesCursos
{
    public class CreateModel : PageModel
    {
        public int idDocente;
        public int idCurso;
        public Persona Docente;
        public Curso Curso;
        public async Task<IActionResult> OnGet(int iddocente, int idcurso)
        {
            idDocente = iddocente;
            idCurso = idcurso;
            Docente = await PersonasApiClient.GetAsync(idDocente);
            Curso = await CursosApiClient.GetAsync(idCurso);
            return Page();
        }

        [BindProperty]
        public Docente_Curso Docente_Curso { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            await DocentesCursosApiClient.AddAsync(Docente_Curso);

            return RedirectToPage("../AsignarProfesores", new {idcurso = Docente_Curso.IdCurso });
        }
    }
}
