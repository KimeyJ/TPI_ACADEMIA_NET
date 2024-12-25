using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Domain.Model
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion {  get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public DateTime Fecha_nac { get; set; }
        public int Legajo {  get; set; }
        public List<Usuario> Usuarios { get; set; }
        

    }

    public class Profesor: Persona
    {
        public List<Curso> Cursos { get; set; }
    }

    public class Alumno: Persona
    {
        public List<Curso> Cursos { get; set; }
        public Especialidad Especialidad { get; set; }
    }
}
