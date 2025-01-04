using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Docente_Curso
    {
        public int Docente_CursoId { get; set; }
        public int IdDocente { get; set; }
        public int IdCurso { get; set; }
        public Persona Docente { get; set; }
        public Curso Curso { get; set; }
        public int Cargo { get; set; } // 1: Teoria    2: Practica
    }
}
