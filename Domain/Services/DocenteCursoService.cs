using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class DocenteCursoService
    {
        //private readonly AcademiaContext _context;
        public int Add(Docente_Curso Docente_Curso)
        {
            using (var _context = new AcademiaContext())
            {
                _context.Docentes_Cursos.Add(Docente_Curso);
                _context.SaveChanges();

                return Docente_Curso.Docente_CursoId;
            }

        }

        public void Delete(int id)
        {
            using (var _context = new AcademiaContext())
            {
                Docente_Curso? Docente_CursoToDelete = _context.Docentes_Cursos.Find(id);
                if (Docente_CursoToDelete != null)
                {
                    _context.Docentes_Cursos.Remove(Docente_CursoToDelete);
                    _context.SaveChanges();
                }
            }
        }
        public Docente_Curso? Get(int id)
        {
            using (var _context = new AcademiaContext())
            {
                return _context.Docentes_Cursos.Find(id);
            }

        }

        public IEnumerable<Docente_Curso> GetAll()
        {
            using (var _context = new AcademiaContext())
            {
                return _context.Docentes_Cursos.ToList();
            }
        }
        public void Update(Docente_Curso Docente_Curso)
        {
            using (var _context = new AcademiaContext())
            {
                Docente_Curso? Docente_CursoToUpdate = _context.Docentes_Cursos.Find(Docente_Curso.Docente_CursoId);
                if (Docente_CursoToUpdate != null)
                {
                    Docente_CursoToUpdate.Docente = Docente_Curso.Docente;
                    Docente_CursoToUpdate.Cargo = Docente_Curso.Cargo;
                    Docente_CursoToUpdate.Curso = Docente_Curso.Curso;
                    _context.SaveChanges();
                }
            }

        }
    }
}
