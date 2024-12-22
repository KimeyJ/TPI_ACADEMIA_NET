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
        public int EspecialidadId { get; set; }
        public string Descripcion { get; set; }
        public List<Plan> Planes { get; set; }
    }
}
