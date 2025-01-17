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

namespace WebUI.Pages.Cursos
{
    public class IndexModel : PageModel
    {


        public IList<Curso> Curso { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Curso = (IList<Curso>)await CursosApiClient.GetAllAsync(0,0);
        }
    }
}
