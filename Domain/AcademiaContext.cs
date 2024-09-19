using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    internal class AcademiaContext : DbContext
    {
        internal AcademiaContext(DbContextOptions<AcademiaContext> options) : base(options)
        {
        }
    }
}
