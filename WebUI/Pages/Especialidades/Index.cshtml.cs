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

namespace WebUI.Pages.Especialidades
{
    public class IndexModel : PageModel
    {
        public IList<Especialidad> Especialidad { get;set; } = default!;
        public string filterString;

        public async Task OnGetAsync(string filter)
        {
            filterString = filter;
            Especialidad = (IList<Especialidad>)await EspecialidadesApiClient.GetAllAsync();
        }
    }
}
