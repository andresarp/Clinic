using System.ComponentModel.DataAnnotations;

namespace Clinica.Areas.Doctors.Models
{
    public class InputModelRegister
    {
        [Required(ErrorMessage = "El campo cédula es obligatorio")]
        public string idUser { get; set; }

        [Required(ErrorMessage = "El campo nombre es obligatorio")]
        public string name { get; set; }

        [Required(ErrorMessage = "El campo apellido es obligatorio")]
        public string lastName { get; set; }

        [Required(ErrorMessage = "El campo especialidad es obligatorio")]
        public string specialty { get; set; }
    }
}
