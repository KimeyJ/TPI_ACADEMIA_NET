using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class PersonaService
    {
        //private readonly AcademiaContext _context;
        public int Add(Persona Persona)
        {
            using (var _context = new AcademiaContext())
            {
                _context.Personas.Add(Persona);
                _context.SaveChanges();

                return Persona.Legajo;
            }

        }

        public void Delete(int id)
        {
            using (var _context = new AcademiaContext())
            {
                Persona? PersonaToDelete = _context.Personas.Find(id);
                if (PersonaToDelete != null)
                {
                    _context.Personas.Remove(PersonaToDelete);
                    _context.SaveChanges();
                }
            }
        }
        public Persona? Get(int id)
        {
            using (var _context = new AcademiaContext())
            {
                return _context.Personas.Find(id);
            }

        }

        public IEnumerable<Persona> GetAll(int tipoPersona)
        {
            using (var _context = new AcademiaContext())
            {
                if(tipoPersona == 0)
                {
                    return _context.Personas.ToList();
                }
                else
                {
                    var rta = _context.Personas.ToList();
                    return from p in rta where p.Tipo_persona == tipoPersona select p;
                }
                
            }
        }
        public void Update(Persona Persona)
        {
            using (var _context = new AcademiaContext())
            {
                Persona? PersonaToUpdate = _context.Personas.Find(Persona.Legajo);
                if (PersonaToUpdate != null)
                {
                    PersonaToUpdate.Nombre = Persona.Nombre;
                    PersonaToUpdate.Apellido = Persona.Apellido;
                    PersonaToUpdate.Direccion = Persona.Direccion;
                    PersonaToUpdate.Email = Persona.Email;
                    PersonaToUpdate.Fecha_nac = Persona.Fecha_nac;
                    PersonaToUpdate.Telefono = Persona.Telefono;
                    _context.SaveChanges();
                }
            }

        }
    }
}
