using System;
using System.Collections.Generic;

namespace Clinica.Models
{
    public partial class Patient
    {
        public int IdUser { get; set; }
        public string Name { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
    }
}
