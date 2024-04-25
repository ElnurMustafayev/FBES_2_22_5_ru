namespace DependencyInjectionApp.Controllers;

using DependencyInjectionApp.Models;
using DependencyInjectionApp.Repositories.Base;
using DependencyInjectionApp.Services.Base;
using Microsoft.AspNetCore.Mvc;

public class ProductController : Controller
{
    private readonly IProductService productService;
    private readonly IProductRepository productRepository;

    public ProductController(
        IProductService productService,
        IProductRepository productRepository)
    {
        System.Console.WriteLine("Controller CTOR");
        this.productRepository = productRepository;
        this.productService = productService;
    }

    [HttpGet("api/[controller]")]
    public async Task<IActionResult> Index() {
        var products = await productRepository.GetAllAsync();

        return base.View(products);
    }

    public async Task<IActionResult> Create() {
        var productToAdd = new Product {
            Name = "Qwerty"
        };
        await productService.CreateNewProductAsync(productToAdd);

        return Ok();
    }
}