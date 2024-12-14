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
                  .HasKey(m => m.Id);
            modelBuilder.Entity<Curso>()
                  .HasKey(m => m.Id);
            modelBuilder.Entity<Especialidad>()
                  .HasKey(m => m.Id);
            modelBuilder.Entity<Materia>()
                  .HasKey(m => m.Id);
            modelBuilder.Entity<Persona>().HasMany(m => m.Cursos);
            modelBuilder.Entity<Persona>().HasMany(m => m.Materias);
            modelBuilder.Entity<Persona>().HasOne(m => m.Especialidad);
            modelBuilder.Entity<Plan>()
                  .HasKey(m => m.Id);
            modelBuilder.Entity<Usuario>()
                  .HasKey(m => m.Id);
        }
    }
}
