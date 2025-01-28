using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Domain.Model;
using WebUI.Controllers;

namespace WebUI.Pages
{
    public class InscripcionAlumnoModel : PageModel
    {
        public IList<Curso> Curso { get; set; } = default!;
        public IList<Inscripcion> Inscripciones { get; set; } = default!;
        public string filterString;
        public int idAlumno = 0;
        public int idCurso = 0;

        public async Task OnGetAsync(string filter, string id, string idcurso)
        {
            idAlumno = Convert.ToInt32(id);
            idCurso = Convert.ToInt32(idcurso);
            filterString = filter;
            Curso = (IList<Curso>)await CursosApiClient.GetAllAsync(0, 0);
            Inscripciones = (IList<Inscripcion>)await InscripcionesApiClient.GetAllAsync(idAlumno, false);

            foreach (Curso curso in Curso)
            {
                curso.Materia = await MateriasApiClient.GetAsync(curso.IdMateria);
                curso.Comision = await ComisionesApiClient.GetAsync(curso.IdComision);
            }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            Inscripcion nuevaInscripcion = new Inscripcion();
            nuevaInscripcion.IdCurso = idCurso;
            nuevaInscripcion.IdAlumno = idAlumno;

            await InscripcionesApiClient.AddAsync(nuevaInscripcion);

            return Page();
        }
    }
}
