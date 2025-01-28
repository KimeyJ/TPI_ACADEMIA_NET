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
using System.Numerics;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebUI.Pages.Cursos
{
    public class IndexModel : PageModel
    {


        public IList<Curso> Curso { get;set; } = default!;
        public string filterString;
        public string plan;
        public int idPlan = 0;

        public async Task OnGetAsync(string filter, string id)
        {
            idPlan = Convert.ToInt32(id);
            filterString = filter;
            Curso = (IList<Curso>)await CursosApiClient.GetAllAsync(0, 0);
            //plan = (await PlanesApiClient.GetAsync(idPlan)).Descripcion;
            
            foreach (Curso curso in Curso)
            {
                curso.Materia = await MateriasApiClient.GetAsync(curso.IdMateria);
                curso.Comision = await ComisionesApiClient.GetAsync(curso.IdComision);

            }
        }
    }
}
