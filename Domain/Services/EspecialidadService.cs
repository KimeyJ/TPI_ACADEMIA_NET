using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Domain.Services
{
    public class EspecialidadService
    {
        //private readonly AcademiaContext _context;
        public void Add(Especialidad especialidad)
        {
            using(var _context = new AcademiaContext())
            {
                _context.Especialidades.Add(especialidad);
                _context.SaveChanges();
            }
            
        }

        public void Delete(int id)
        {
            using (var _context = new AcademiaContext())
            {
                Especialidad? especialidadToDelete = _context.Especialidades.Find(id);
                if (especialidadToDelete != null)
                {
                    _context.Especialidades.Remove(especialidadToDelete);
                    _context.SaveChanges();
                }
            }     
        }
        public Especialidad? Get(int id)
        {
            using (var _context = new AcademiaContext())
            {
                return _context.Especialidades.Find(id);
            }
            
        }

        public IEnumerable<Especialidad> GetAll()
        {
            using (var _context = new AcademiaContext())
            {
                return _context.Especialidades.ToList();
            }
        }
        public void Update(Especialidad especialidad)
        {
            using (var _context = new AcademiaContext())
            {
                Especialidad? especialidadToUpdate = _context.Especialidades.Find(especialidad.Id);
                if (especialidadToUpdate != null)
                {
                    especialidadToUpdate.descripcion = especialidad.descripcion;
                    _context.SaveChanges();
                }
            }
                
        }
    }
}
