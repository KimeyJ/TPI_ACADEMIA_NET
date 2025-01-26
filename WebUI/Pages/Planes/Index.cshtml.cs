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

namespace WebUI.Pages.Planes
{
    public class IndexModel : PageModel
    {

        public IList<Plan> Plan { get;set; } = default!;
        public string filterString;
        public int idEsp;

        public async Task OnGetAsync(string filter, string id)
        {
            filterString = filter;
            idEsp = Convert.ToInt32(id);
            Plan = (IList<Plan>)await PlanesApiClient.GetAllAsync(idEsp);
            foreach (var plan in Plan)
            {
                plan.Especialidad = await EspecialidadesApiClient.GetAsync(plan.IdEsp);
            }
        }
    }
}
