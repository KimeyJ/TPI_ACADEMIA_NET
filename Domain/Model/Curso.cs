using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Curso
    {
        public int CursoId { get; set; }
        public int IdMateria { get; set; }
        public Materia Materia { get; set; }
        public int IdComision { get; set; }
        public Comision Comision { get; set; }
        public List<Docente_Curso> Profesores { get; set; }  
        public List<Inscripcion> Alumnos { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Cupo { get; set; }
        public int AñoCalendario { get; set; }

    }
}
