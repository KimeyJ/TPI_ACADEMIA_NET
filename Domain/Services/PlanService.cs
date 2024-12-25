using Domain.Model;
using Microsoft.AspNetCore.Http.Timeouts;
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

        public IEnumerable<Plan> GetAll(int id)
        {
            using (var _context = new AcademiaContext())
            {
                var rta = _context.Planes.ToList();
                if (id == 0)
                {
                    return rta;
                }
                else
                {
                    return from p in rta where p.IdEsp == id select p;
                }
                
            }
        }

        public Plan GetLast(int id)
        {
            using(var _context = new AcademiaContext())
            {
                var planes = _context.Planes.ToList();
                var planEsp = from p in planes where p.IdEsp == id select p;
                return (Plan)planEsp.Last();
            }
        }

        public void Update(Plan Plan)
        {
            using (var _context = new AcademiaContext())
            {
                Plan? PlanToUpdate = _context.Planes.Find(Plan.PlanId);
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
