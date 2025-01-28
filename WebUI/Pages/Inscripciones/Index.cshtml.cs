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

namespace WebUI.Pages.Inscripciones
{
    public class IndexModel : PageModel
    {

        public IList<Inscripcion> Inscripcion { get;set; } = default!;
        public int Id;
        public bool TipoId;

        public async Task OnGetAsync(string id, string tipoId)
        {
            Id = Convert.ToInt32(id);
            TipoId = Convert.ToBoolean(tipoId);
            Inscripcion = (IList<Inscripcion>)await InscripcionesApiClient.GetAllAsync(Id,TipoId);
            foreach (Inscripcion inscripcion in Inscripcion)
            {
                inscripcion.Alumno = await PersonasApiClient.GetAsync(inscripcion.IdAlumno);
                inscripcion.Curso = await CursosApiClient.GetAsync(inscripcion.IdCurso);
            }
        }
    }
}
