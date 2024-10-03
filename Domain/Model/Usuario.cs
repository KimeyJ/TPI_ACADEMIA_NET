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
        [Key]
        public int Id {  get; set; }
        [Key]
        public int IdPersona { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
