using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Clinica.Models
{
    public partial class Appointments
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo fecha es obligatorio")]
        public DateTime Date { get; set; }
        [Required(ErrorMessage = "El campo paciente es obligatorio")]
        public int IdPatient { get; set; }
        [Required(ErrorMessage = "El campo doctor es obligatorio")]
        public string IdDoctor { get; set; } = null!;
        [Required(ErrorMessage = "El campo especialidad es obligatorio")]
        public int Speciality { get; set; }
        [Required(ErrorMessage = "El campo costo es obligatorio")]
        public decimal Cost { get; set; }
    }
}
