﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Comision
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int PlanId { get; set; }
        public string Descripcion { get; set; }
    }
}
