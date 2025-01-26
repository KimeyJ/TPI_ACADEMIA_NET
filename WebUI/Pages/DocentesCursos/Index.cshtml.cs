using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Domain;
using WebUI.Controllers;
using Domain.Model;

namespace WebUI.Pages.DocentesCursos
{
    public class IndexModel : PageModel
    {
        public IList<Docente_Curso> Docente_Curso { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Docente_Curso = (IList<Docente_Curso>)await DocentesCursosApiClient.GetAllAsync(0,false);
            foreach (Docente_Curso docente_curso in Docente_Curso)
            {
                docente_curso.Docente = await PersonasApiClient.GetAsync(docente_curso.IdDocente);
                docente_curso.Curso = await CursosApiClient.GetAsync(docente_curso.IdCurso);
            }
        }
    }
}
