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
        public DbSet<Inscripcion> Inscripciones_Alumnos { get; set; }
        public DbSet<Docente_Curso> Docentes_Cursos { get; set; }
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
            
            modelBuilder.Entity<Docente_Curso>()
                .HasOne(dc => dc.Docente)
                .WithMany(p => p.CursosProfesor)
                .HasForeignKey(dc => dc.IdDocente).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Docente_Curso>()
                .HasOne(dc => dc.Curso)
                .WithMany(c => c.Profesores)
                .HasForeignKey(dc => dc.IdCurso);

            modelBuilder.Entity<Inscripcion>()
                .HasOne(i => i.Alumno)
                .WithMany(p => p.CursosAlumno)
                .HasForeignKey(i => i.IdAlumno);
            modelBuilder.Entity<Inscripcion>()
                .HasOne(i => i.Curso)
                .WithMany(c => c.Alumnos)
                .HasForeignKey(i => i.IdAlumno).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Materia>()
                  .HasOne(m => m.Plan)
                  .WithMany(p => p.Materias)
                  .HasForeignKey(m => m.IdPlan);

            modelBuilder.Entity<Persona>().HasKey(p => p.Legajo);

            modelBuilder.Entity<Plan>()
                  .HasOne(p => p.Especialidad)
                  .WithMany(e=> e.Planes)
                  .HasForeignKey(p => p.IdEsp);

            modelBuilder.Entity<Usuario>()
                  .HasOne(u => u.Persona)
                  .WithMany(p => p.Usuarios)
                  .HasForeignKey(u=>u.IdPersona);
        }
    }
}
