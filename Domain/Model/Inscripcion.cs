using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Inscripcion
    {
        public int InscripcionId { get; set; }
        public int IdAlumno { get; set; }
        public int IdCurso { get; set; }
        public Persona Alumno { get; set; }
        public Curso Curso { get; set; }
        public int Nota { get; set; }

    }
}
