using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class CursoService
    {
        //private readonly AcademiaContext _context;
        public void Add(Curso Curso)
        {
            using (var _context = new AcademiaContext())
            {
                _context.Cursos.Add(Curso);
                _context.SaveChanges();
            }

        }

        public void Delete(int id)
        {
            using (var _context = new AcademiaContext())
            {
                Curso? CursoToDelete = _context.Cursos.Find(id);
                if (CursoToDelete != null)
                {
                    _context.Cursos.Remove(CursoToDelete);
                    _context.SaveChanges();
                }
            }
        }
        public Curso? Get(int id)
        {
            using (var _context = new AcademiaContext())
            {
                return _context.Cursos.Find(id);
            }

        }

        public IEnumerable<Curso> GetAll()
        {
            using (var _context = new AcademiaContext())
            {
                return _context.Cursos.ToList();
            }
        }
        public void Update(Curso Curso)
        {
            using (var _context = new AcademiaContext())
            {
                Curso? CursoToUpdate = _context.Cursos.Find(Curso.Id);
                if (CursoToUpdate != null)
                {
                    CursoToUpdate.Descripcion = Curso.Descripcion;
                    CursoToUpdate.MateriaId = Curso.MateriaId;
                    CursoToUpdate.ComisionId = Curso.ComisionId;
                    CursoToUpdate.AñoCalendario = Curso.AñoCalendario;
                    CursoToUpdate.Cupo = Curso.Cupo;
                    CursoToUpdate.Nombre = Curso.Nombre;
                    _context.SaveChanges();
                }
            }

        }
    }
}
