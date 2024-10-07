using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Curso
    {
        public int Id { get; set; }
        [Required]
        public int MateriaId { get; set; }
        [Required]
        public int ComisionId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Cupo { get; set; }
        public int AñoCalendario { get; set; }

    }
}
