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
        private readonly Domain.AcademiaContext _context;

        public IndexModel(Domain.AcademiaContext context)
        {
            _context = context;
        }

        public IList<Docente_Curso> Docente_Curso { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Docente_Curso = (IList<Docente_Curso>)await DocentesCursosApiClient.GetAllAsync(0,false);
        }
    }
}
