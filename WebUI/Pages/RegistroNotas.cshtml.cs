using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Domain;
using Domain.Model;
using WebUI.Controllers;

namespace WebUI.Pages
{
    public class RegistroNotasModel : PageModel
    {
        public IList<Inscripcion> Inscripciones { get; set; } = default!;
        [BindProperty]
        public int idCurso { get; set; } = default!;
        [BindProperty]
        public int Count { get; set; } = default!;
        [BindProperty]
        public Inscripcion Inscripcion { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int CursoId, int count)
        {
            idCurso = CursoId;
            Count = count;
            Inscripciones = (IList<Inscripcion>)await InscripcionesApiClient.GetAllAsync(CursoId, false);
            if(Count == Inscripciones.Count)
            {
                return RedirectToPage("./Inscripciones/Index", new { id = CursoId, tipoId = false });
            }
            else
            {
                Inscripcion = Inscripciones.ElementAt(Count);
                foreach (Inscripcion inscripcion in Inscripciones)
                {
                    inscripcion.Alumno = await PersonasApiClient.GetAsync(inscripcion.IdAlumno);
                }
                return Page();
            }
            
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await InscripcionesApiClient.UpdateAsync(Inscripcion);

            return RedirectToPage("./RegistroNotas", new { CursoId = idCurso, count = Count + 1 });
        }
    }
}
