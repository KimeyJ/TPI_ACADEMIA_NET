using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Domain
{
    internal class EspecialidadContext : DbContext
    {
        internal DbSet<Especialidad> Especialidades { get; set; }

        internal EspecialidadContext()
        {
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Initial Catalog=EspecialidadDb");
    }
}
