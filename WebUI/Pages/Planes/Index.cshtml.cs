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

        public async Task OnGetAsync()
        {
            Plan = (IList<Plan>)await PlanesApiClient.GetAllAsync(0);
        }
    }
}
