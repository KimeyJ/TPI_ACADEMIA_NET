using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Domain.Model;
using WebUI.Controllers;
using System.Numerics;

namespace WebUI.Pages
{
    public class AsignarProfesoresModel : PageModel
    {

        public int idFilter;
        public string apelFilter;
        public int planFilter;
        public int idCurso;
        public IList<Persona> Persona { get; set; } = default!;
        public IList<Plan> Plan { get; set; } = default!;
        public IList<Docente_Curso> Profesores { get; set; } = default!;
        [BindProperty]
        public Docente_Curso Asignacion { get; set; } = default!;
        public async Task OnGetAsync(int id, string apellido, int plan, int idcurso)
        {
            idFilter = id;
            apelFilter = apellido;
            planFilter = plan;
            idCurso = idcurso;
            Persona = (IList<Persona>)await PersonasApiClient.GetAllAsync(2);
            Plan = (IList<Plan>)await PlanesApiClient.GetAllAsync(0);
            Profesores = (IList<Docente_Curso>)await DocentesCursosApiClient.GetAllAsync(idCurso, true);
            foreach (Docente_Curso docente_Curso in Profesores)
            {
                    docente_Curso.Docente = await PersonasApiClient.GetAsync(docente_Curso.IdDocente);
            }

            
        }

        public async Task<IActionResult> onPostAsync()
        { 
            await DocentesCursosApiClient.DeleteAsync(Asignacion.Docente_CursoId);

            return RedirectToPage("./AsignarProfesores", new { id = idFilter, apellido = apelFilter, plan = planFilter, idcurso = Asignacion.IdCurso });
        }
    }
}