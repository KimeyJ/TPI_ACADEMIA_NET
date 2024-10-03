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
        [Key]
        public int Id { get; set; }
        [Key]
        public int IdPlan { get; set; }
        public string Descripcion { get; set; }
        public int HsSemanales {  get; set; }
        public int HsTotales {  get; set; }
    }
}
