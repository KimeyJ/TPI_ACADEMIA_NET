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
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebUI.Pages.Comisiones
{
    public class IndexModel : PageModel
    {

        public IList<Comision> Comision { get;set; } = default!;
        public string filterString;
        public int idPlan;

        public async Task OnGetAsync(string filter, string id)
        {
            ViewData["IdPlan"] = new SelectList(await PlanesApiClient.GetAllAsync(0), "PlanId", "Descripcion");
            Comision = (IList<Comision>)await ComisionesApiClient.GetAllAsync(Convert.ToInt32(id));

            filterString = filter;
            idPlan = Convert.ToInt32(id);

            foreach (var comision in Comision)
            {
                comision.Plan = await PlanesApiClient.GetAsync(comision.IdPlan);
            }
        }
    }
}
