using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Comision
    {
        public int ComisionId { get; set; }
        public int IdPlan { get; set; }
        public Plan Plan { get; set; }
        public string Descripcion { get; set; }
        public List<Curso> Cursos { get; set; }
    }
}
