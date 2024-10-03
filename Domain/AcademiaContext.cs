using Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class AcademiaContext : DbContext
    {
        public DbSet<Especialidad> Especialidades { get; set; }

        public AcademiaContext(DbContextOptions<AcademiaContext> options) : base(options)
        {
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS; Database=Academia; Integrated Security=True; TrustServerCertificate=True");
            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
        }
    }
}
