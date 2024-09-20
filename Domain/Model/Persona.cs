﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Domain.Model
{
    public class Persona
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion {  get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public DateOnly Fecha_nac { get; set; }
        public int Legajo {  get; set; }
        [Required]
        public int Tipo_persona { get; set; }

    }
}
