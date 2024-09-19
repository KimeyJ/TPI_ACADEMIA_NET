using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Domain
{
    internal class PersonaContext : DbContext
    {
        internal DbSet<Persona> Personas { get; set; }

        internal PersonaContext()
        {
            this.Database.EnsureCreated();
        }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Initial Catalog=ClienteDb");*/
    }
}
