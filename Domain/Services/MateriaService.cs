using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class MateriaService
    {
        //private readonly AcademiaContext _context;
        public void Add(Materia Materia)
        {
            using (var _context = new AcademiaContext())
            {
                _context.Materias.Add(Materia);
                _context.SaveChanges();
            }

        }

        public void Delete(int id)
        {
            using (var _context = new AcademiaContext())
            {
                Materia? MateriaToDelete = _context.Materias.Find(id);
                if (MateriaToDelete != null)
                {
                    _context.Materias.Remove(MateriaToDelete);
                    _context.SaveChanges();
                }
            }
        }
        public Materia? Get(int id)
        {
            using (var _context = new AcademiaContext())
            {
                return _context.Materias.Find(id);
            }

        }

        public IEnumerable<Materia> GetAll()
        {
            using (var _context = new AcademiaContext())
            {
                return _context.Materias.ToList();
            }
        }
        public void Update(Materia Materia)
        {
            using (var _context = new AcademiaContext())
            {
                Materia? MateriaToUpdate = _context.Materias.Find(Materia.Id);
                if (MateriaToUpdate != null)
                {
                    MateriaToUpdate.Descripcion = Materia.Descripcion;
                    MateriaToUpdate.IdPlan = Materia.IdPlan;
                    MateriaToUpdate.HsSemanales = Materia.HsSemanales;
                    MateriaToUpdate.HsTotales = Materia.HsTotales;
                    _context.SaveChanges();
                }
            }

        }
    }
}
