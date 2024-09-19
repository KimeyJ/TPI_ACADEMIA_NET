using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;

namespace Domain.Services
{
    public class EspecialidadService
    {
        public void Add(Especialidad especialidad)
        {
            using var context = new EspecialidadContext;

            context.Personas.Add(especialidad);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new EspecialidadContext;
            Especialidad? especialidadToDelete = context.Especialidades.Find(id);
            if (especialidadToDelete != null)
            {
                context.Especialidades.Remove(especialidadToDelete);
                context.SaveChanges();
            }
        }
        public Especialidad? Get(int id)
        {
            using var context = new EspecialidadContext();
            return context.Especialidades.Find(id);
        }

        public IEnumerable<Especialidad> GetAll()
        {
            using var context = new EspecialidadContext();

            return context.Especialidades.ToList();
        }
        public void Update(Especialidad especialidad)
        {
            using var context = new EspecialidadContext();
            Especialidad? especialidadToUpdate = context.Especialidades.Find(especialidad.Id);
            if (especialidadToUpdate != null)
            {
                especialidadToUpdate.descripcion = especialidad.descripcion;
                context.SaveChanges();
            }
        }
    }
}
