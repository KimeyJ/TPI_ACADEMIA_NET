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

namespace WebUI.Pages.Comisiones
{
    public class IndexModel : PageModel
    {

        public IList<Comision> Comision { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Comision = (IList<Comision>)await ComisionesApiClient.GetAllAsync(0);
        }
    }
}
