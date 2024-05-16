using FluentValidation;
using FluentValidationApp.Models;

namespace FluentValidationApp.Validators;

public class ProductValidator : AbstractValidator<Product>
{
    public ProductValidator()
    {
        base.RuleFor(product => product.Name)
            .NotEmpty()
            .Length(5, 20)
            .NotEqual("Badword");

        base.RuleFor(product => product.Price)
            .NotEmpty()
            .GreaterThan(0);
    }
}