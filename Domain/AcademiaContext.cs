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
        public DbSet<Comision> Comisiones { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Plan> Planes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public AcademiaContext()
        {
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS; Database=Academia; Integrated Security=True; TrustServerCertificate=True");
            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comision>()
                  .HasKey(m => new { m.Id, m.PlanId });
            modelBuilder.Entity<Curso>()
                  .HasKey(m => new { m.Id});
            modelBuilder.Entity<Especialidad>()
                  .HasKey(m => new { m.Id });
            modelBuilder.Entity<Materia>()
                  .HasKey(m => new { m.Id, m.IdPlan });
            modelBuilder.Entity<Persona>()
                  .HasKey(m => new { m.Id });
            modelBuilder.Entity<Plan>()
                  .HasKey(m => new { m.Id});
            modelBuilder.Entity<Usuario>()
                  .HasKey(m => new { m.Id, m.IdPersona });
        }
    }
}
