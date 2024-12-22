using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Usuario
    {
        public int UsuarioId {  get; set; }
        public int IdPersona { get; set; }
        public Persona Persona { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
