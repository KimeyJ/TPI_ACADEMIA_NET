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
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Profesor> Profesors { get; set; }
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
                .HasOne(c=> c.Plan)
                .WithMany(p => p.Comisiones)
                .HasForeignKey(c=> c.IdPlan);

            modelBuilder.Entity<Curso>()
                  .HasOne(c=>c.Materia)
                  .WithMany(m=> m.Cursos)
                  .HasForeignKey(c=> c.IdMateria).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Curso>()
                .HasOne(c=>c.Comision)
                .WithMany(m=> m.Cursos)
                .HasForeignKey(c=> c.IdComision);
            modelBuilder.Entity<Curso>().HasOne(c => c.Profesor).WithMany(p => p.Cursos).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Materia>()
                  .HasOne(m => m.Plan)
                  .WithMany(p => p.Materias)
                  .HasForeignKey(m => m.IdPlan);

            modelBuilder.Entity<Persona>().HasKey(p => p.Legajo);

            modelBuilder.Entity<Plan>()
                  .HasOne(p => p.Especialidad).WithMany(e=> e.Planes).HasForeignKey(p => p.IdEsp);
            modelBuilder.Entity<Usuario>()
                  .HasOne(u => u.Persona).WithMany(p => p.Usuarios).HasForeignKey(u=>u.IdPersona);
        }
    }
}
