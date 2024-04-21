namespace DependencyInjectionApp.Controllers;

using DependencyInjectionApp.Repositories.Base;
using Microsoft.AspNetCore.Mvc;

public class ProductController : Controller
{
    private readonly IProductRepository productRepository;

    public ProductController(IProductRepository productRepository)
    {
        this.productRepository = productRepository;
    }

    [HttpGet]
    public async Task<IActionResult> Index() {
        var products = await productRepository.GetAllAsync();

        return base.View(products);
    }
}