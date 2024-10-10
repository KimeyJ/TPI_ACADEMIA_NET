using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class PlanService
    {
        //private readonly AcademiaContext _context;
        public void Add(Plan Plan)
        {
            using (var _context = new AcademiaContext())
            {
                _context.Planes.Add(Plan);
                _context.SaveChanges();
            }

        }

        public void Delete(int id)
        {
            using (var _context = new AcademiaContext())
            {
                Plan? PlanToDelete = _context.Planes.Find(id);
                if (PlanToDelete != null)
                {
                    _context.Planes.Remove(PlanToDelete);
                    _context.SaveChanges();
                }
            }
        }
        public Plan? Get(int id)
        {
            using (var _context = new AcademiaContext())
            {
                return _context.Planes.Find(id);
            }

        }

        public IEnumerable<Plan> GetAll()
        {
            using (var _context = new AcademiaContext())
            {
                return _context.Planes.ToList();
            }
        }
        public void Update(Plan Plan)
        {
            using (var _context = new AcademiaContext())
            {
                Plan? PlanToUpdate = _context.Planes.Find(Plan.Id);
                if (PlanToUpdate != null)
                {
                    PlanToUpdate.Descripcion = Plan.Descripcion;
                    PlanToUpdate.Año = Plan.Año;
                    _context.SaveChanges();
                }
            }

        }
    }
}
