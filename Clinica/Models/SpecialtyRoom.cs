using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Clinica.Models
{
    public partial class SpecialtyRoom
    {
        public int idSpecialtyRoom { get; set; }
        [Required(ErrorMessage = "El campo número de consultorio es obligatorio")]
        public int number { get; set; }
        [Required(ErrorMessage = "El campo especialidad es obligatorio")]
        public int specialty { get; set;}
    }
}
