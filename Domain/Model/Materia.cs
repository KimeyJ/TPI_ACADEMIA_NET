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
        public int Id { get; set; }
        [Required]
        public int IdPlan { get; set; }
        [Required]
        public string Descripcion { get; set; }
        public int HsSemanales {  get; set; }
        public int HsTotales {  get; set; }
    }
}
