using System;
using System.Collections.Generic;

namespace Clinica.Models
{
    public partial class Appointments
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int IdPatient { get; set; }
        public string IdDoctor { get; set; } = null!;
        public int Speciality { get; set; }
        public decimal Cost { get; set; }
    }
}
