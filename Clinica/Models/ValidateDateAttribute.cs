using System.ComponentModel.DataAnnotations;

namespace Clinica.Models
{
    internal class ValidateDateAttribute : Attribute
    {
        protected  ValidationResult IsValid (object date, ValidationContext validationContext)
        {
            //return (date <= DateTime.Now && date >= DateTime.Now.AddYears(-1))
            //    ? ValidationResult.Success
            //    : new ValidationResult("Invalid date range");
            return null;
        }
    }
}