using System.ComponentModel.DataAnnotations;

namespace Clinica.Areas.Doctors.Models
{
    public class InputModelRegister
    {
        [Required(ErrorMessage = "El campo cédula es obligatorio")]
        public string id { get; set; }

        [Required(ErrorMessage = "El campo nombre es obligatorio")]
        public string name { get; set; }

        [Required(ErrorMessage = "El campo apellido es obligatorio")]
        public string lastName { get; set; }

        [Required(ErrorMessage = "El campo especialidad es obligatorio")]
        public string specialty { get; set; }

        /*
        [Required(ErrorMessage = "El campo qualities es obligatorio")]
        public string qualities { get; set; }
        */

        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{2})\)?[-. ]?([0-9]{2})[-. ]?([0-9]{5})$", ErrorMessage = "El formato telefonico ingresado no es valido.")]
        public string phoneNumber { get; set; }

    }
}
