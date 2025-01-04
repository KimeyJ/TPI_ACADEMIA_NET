using Domain.Model;
using Microsoft.EntityFrameworkCore;
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
        public int Add(Curso Curso)
        {
            using (var _context = new AcademiaContext())
            {
                _context.Cursos.Add(Curso);
                _context.SaveChanges();

                return Curso.CursoId;
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

        public IEnumerable<Curso> GetAll(int id_m, int id_c)
        {
            using (var _context = new AcademiaContext())
            {
                var rta = _context.Cursos.ToList();
                if (id_m == 0 && id_c == 0)
                {
                    return rta;
                }
                else
                {
                    return from c in rta where c.IdComision == id_c && c.IdMateria == id_m select c; 
                }
                
            }
        }

        public IEnumerable<Curso> GetAllByPlan(int id)
        {
            using(var _context = new AcademiaContext())
            {
                var rta = _context.Cursos.ToList();
                return from c in rta where c.Materia.IdPlan == id select c;
            }
            
        }

        public void Update(Curso Curso)
        {
            using (var _context = new AcademiaContext())
            {
                Curso? CursoToUpdate = _context.Cursos.Find(Curso.CursoId);
                if (CursoToUpdate != null)
                {
                    CursoToUpdate.Descripcion = Curso.Descripcion;
                    CursoToUpdate.IdMateria = Curso.IdMateria;
                    CursoToUpdate.IdComision = Curso.IdComision;
                    CursoToUpdate.AñoCalendario = Curso.AñoCalendario;
                    CursoToUpdate.Cupo = Curso.Cupo;
                    CursoToUpdate.Nombre = Curso.Nombre;
                    _context.SaveChanges();
                }
            }

        }
    }
}
