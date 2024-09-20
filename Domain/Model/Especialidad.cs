using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Domain.Model
{
    public class Especialidad
    {
        [Key]
        public int Id { get; set; }
        public string descripcion { get; set; }
    }
}
