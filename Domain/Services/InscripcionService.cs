using Domain.Model;
using Microsoft.AspNetCore.Http.Timeouts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class InscripcionService
    {
        //private readonly AcademiaContext _context;
        public int Add(Inscripcion Inscripcion)
        {
            using (var _context = new AcademiaContext())
            {
                _context.Inscripciones_Alumnos.Add(Inscripcion);
                _context.SaveChanges();

                return Inscripcion.InscripcionId;
            }

        }

        public void Delete(int id)
        {
            using (var _context = new AcademiaContext())
            {
                Inscripcion? InscripcionToDelete = _context.Inscripciones_Alumnos.Find(id);
                if (InscripcionToDelete != null)
                {
                    _context.Inscripciones_Alumnos.Remove(InscripcionToDelete);
                    _context.SaveChanges();
                }
            }
        }
        public Inscripcion? Get(int id)
        {
            using (var _context = new AcademiaContext())
            {
                return _context.Inscripciones_Alumnos.Find(id);
            }

        }

        public IEnumerable<Inscripcion> GetAll(int id, bool tipoId)
        {
            using (var _context = new AcademiaContext())
            {
                var rta = _context.Inscripciones_Alumnos.ToList();
                if (tipoId)
                {
                    return from i in rta where i.IdAlumno == id select i;
                }
                else
                {
                    return from i in rta where i.IdCurso == id select i;
                }
            }
        }

        public void Update(Inscripcion Inscripcion)
        {
            using (var _context = new AcademiaContext())
            {
                Inscripcion? InscripcionToUpdate = _context.Inscripciones_Alumnos.Find(Inscripcion.InscripcionId);
                if (InscripcionToUpdate != null)
                {
                    InscripcionToUpdate.Nota = Inscripcion.Nota;
                    _context.SaveChanges();
                }
            }

        }
    }
}
