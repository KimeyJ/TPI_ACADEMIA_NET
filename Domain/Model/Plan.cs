using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Plan
    {
        public int PlanId { get; set; }
        public int IdEsp { get; set; }
        public Especialidad Especialidad { get; set; }
        public List<Materia> Materias { get; set; }
        public List<Comision> Comisiones { get; set; }
        public List<Persona> Alumnos { get; set; }
        public int Año { get; set; }
        public string Descripcion { get; set; }
    }
}
