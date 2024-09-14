namespace ProductsWebApi.Controllers;

using Microsoft.AspNetCore.Mvc;
using ProductsWebApi.Entities;
using ProductsWebApi.Repositories.Base;

[Route("/api/[controller]")]
public class ProductController : ControllerBase
{
    private readonly IProductRepository productRepository;

    public ProductController(IProductRepository productRepository)
    {
        this.productRepository = productRepository;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Product>> GetById(int id) {
        var product = await productRepository.GetAsync(id);

        return product != null 
            ? Ok(product)
            : NotFound();
    }
}