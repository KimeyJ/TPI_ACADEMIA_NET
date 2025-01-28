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
        public int Id;
        public bool TipoId;

        public async Task OnGetAsync(string id, string tipoId)
        {
            Id = Convert.ToInt32(id);
            TipoId = Convert.ToBoolean(tipoId);
            Docente_Curso = (IList<Docente_Curso>)await DocentesCursosApiClient.GetAllAsync(Id,TipoId);
            foreach (Docente_Curso docente_curso in Docente_Curso)
            {
                docente_curso.Docente = await PersonasApiClient.GetAsync(docente_curso.IdDocente);
                docente_curso.Curso = await CursosApiClient.GetAsync(docente_curso.IdCurso);
            }
        }
    }
}
