#pragma warning disable CS8618

using System.ComponentModel.DataAnnotations;
using ModelStateValidationApp.Validators;

namespace ModelStateValidationApp.Models;

public class Product
{
    // [MyValidator]
    [Required(ErrorMessage = "Name is Required!")]
    public string Name { get; set; }

    [Required]
    [Range(0, 1_000_000)]
    public decimal Price { get; set; }
}