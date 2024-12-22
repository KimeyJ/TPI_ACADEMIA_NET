using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Materia
    {
        public int MateriaId { get; set; }
        public int IdPlan { get; set; }
        public Plan Plan { get; set; }
        public string Descripcion { get; set; }
        public int HsSemanales {  get; set; }
        public int HsTotales {  get; set; }
        public List<Curso> Cursos { get; set; }
    }
}
