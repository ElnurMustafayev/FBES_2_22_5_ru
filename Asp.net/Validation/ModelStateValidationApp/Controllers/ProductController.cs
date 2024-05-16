namespace ModelStateValidationApp.Controllers;

using Microsoft.AspNetCore.Mvc;
using ModelStateValidationApp.Models;

[Route("[controller]")]
public class ProductController : Controller
{
    [HttpGet("[action]", Name = "CreateProductView")]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost("[controller]", Name = "CreateProductApi")]
    public IActionResult Create([FromForm]Product newProduct)
    {
        // foreach (var item in base.ModelState)
        // {
        //     System.Console.WriteLine($"{item.Key}:");

        //     foreach (var error in item.Value.Errors)
        //     {
        //         System.Console.WriteLine(" - " + error.ErrorMessage);
        //     }
        // }

        if(base.ModelState.IsValid == false) {
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