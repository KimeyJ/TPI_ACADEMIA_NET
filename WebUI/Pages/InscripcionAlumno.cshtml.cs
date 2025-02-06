using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Domain.Model;
using WebUI.Controllers;

namespace WebUI.Pages
{
    public class InscripcionAlumnoModel : PageModel
    {
        public IList<Curso> Cursos { get; set; } = default!;
        public IList<Inscripcion> Inscripciones { get; set; } = default!;
        public string filterString;
        public int idAlumno;
        public int idCurso;
        public Persona persona;

        [BindProperty]
        public Inscripcion Inscripcion { get; set; } = default!;

        public async Task OnGetAsync(string filter, string id, string idcurso)
        {
            idAlumno = Convert.ToInt32(id);
            persona = await PersonasApiClient.GetAsync(idAlumno);
            idCurso = Convert.ToInt32(idcurso);
            filterString = filter;
            Cursos = (IList<Curso>)await CursosApiClient.GetAllAsync(0, 0);
            Inscripciones = (IList<Inscripcion>)await InscripcionesApiClient.GetAllAsync(idAlumno, false);

            foreach (Curso curso in Cursos)
            {
                curso.Materia = await MateriasApiClient.GetAsync(curso.IdMateria);
                curso.Comision = await ComisionesApiClient.GetAsync(curso.IdComision);
            }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await InscripcionesApiClient.AddAsync(Inscripcion);

            return RedirectToPage("./InscripcionAlumno", new {id = Inscripcion.IdAlumno});
        }
    }
}
