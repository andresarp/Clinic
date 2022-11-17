using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Clinica.Models
{
    public partial class Patient
    {
        [Required(ErrorMessage = "El campo cédula es obligatorio")]
        public int IdUser { get; set; }
        [Required(ErrorMessage = "El campo nombre es obligatorio")]
        public string Name { get; set; } = null!;
        [Required(ErrorMessage = "El campo número es obligatorio")]
        public string PhoneNumber { get; set; } = null!;
    }
}
