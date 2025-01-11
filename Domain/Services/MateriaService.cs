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

        public void Delete(int id, int id_p)
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

        public IEnumerable<Materia> GetAll(int p_id)
        {
            using (var _context = new AcademiaContext())
            {
                var rta = _context.Materias.ToList();
                if (p_id == 0)
                {
                    return rta;
                }
                else
                {
                    return from m in rta where m.IdPlan == p_id select m;
                }
            }
        }
        public void Update(Materia Materia)
        {
            using (var _context = new AcademiaContext())
            {
                Materia? MateriaToUpdate = _context.Materias.Find(Materia.MateriaId);
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
