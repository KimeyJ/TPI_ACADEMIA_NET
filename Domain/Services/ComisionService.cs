using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ComisionService 
    {
        //private readonly AcademiaContext _context;
        public void Add(Comision Comision)
        {
            using (var _context = new AcademiaContext())
            {
                _context.Comisiones.Add(Comision);
                _context.SaveChanges();
            }

        }

        public void Delete(int id)
        {
            using (var _context = new AcademiaContext())
            {
                Comision? ComisionToDelete = _context.Comisiones.Find(id);
                if (ComisionToDelete != null)
                {
                    _context.Comisiones.Remove(ComisionToDelete);
                    _context.SaveChanges();
                }
            }
        }
        public Comision? Get(int id)
        {
            using (var _context = new AcademiaContext())
            {
                return _context.Comisiones.Find(id);
            }

        }

        public IEnumerable<Comision> GetAll(int id)
        {
            using (var _context = new AcademiaContext())
            {
                var rta =  _context.Comisiones.ToList();
                if(id == 0)
                {
                    return rta;
                }
                else
                {
                    return from c in rta where c.IdPlan == id select c;
                }
            }
        }
        public void Update(Comision Comision)
        {
            using (var _context = new AcademiaContext())
            {
                Comision? ComisionToUpdate = _context.Comisiones.Find(Comision.ComisionId);
                if (ComisionToUpdate != null)
                {
                    ComisionToUpdate.Descripcion = Comision.Descripcion;
                    ComisionToUpdate.IdPlan = Comision.IdPlan;
                    _context.SaveChanges();
                }
            }

        }
    }
}
