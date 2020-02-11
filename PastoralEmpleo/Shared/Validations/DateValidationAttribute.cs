using System;
using System.ComponentModel.DataAnnotations;

namespace PastoralEmpleo.Shared.Validations
{
    public class DateValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
                return null;

            DateTime dt = (DateTime)value;
            if (dt <= DateTime.UtcNow)
            {
                return ValidationResult.Success;
            }

            return new ValidationResult(ErrorMessage ?? "La fecha debe ser menor o igual a la actual");
        }
    }
}
