namespace FluentValidationApp.Controllers;

using Microsoft.AspNetCore.Mvc;
using FluentValidationApp.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using FluentValidation;

[Route("[controller]")]
public class ProductController : Controller
{
    private readonly IValidator<Product> productValidator;

    public ProductController(IValidator<Product> productValidator)
    {
        this.productValidator = productValidator;
    }

    [HttpGet("[action]", Name = "CreateProductView")]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost("[controller]", Name = "CreateProductApi")]
    public IActionResult Create([FromForm]Product newProduct)
    {
        var validationResult = productValidator.Validate(newProduct);

        if(validationResult.IsValid == false) {

            foreach (var error in validationResult.Errors)
            {
                base.ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
            }
            return base.View();
        }

        return base.RedirectToAction("All");
    }

    [ActionName("All")]
    [Route("[action]")]
    [HttpGet]
    public IEnumerable<Product> GetAllProducts()
    {
        return new Product[] {
            new Product()
        };
    }
}