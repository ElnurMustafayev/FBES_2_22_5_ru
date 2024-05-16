using System.ComponentModel.DataAnnotations;

namespace ModelStateValidationApp.Validators;

public class MyValidatorAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        return base.IsValid(value, validationContext);
    }
}