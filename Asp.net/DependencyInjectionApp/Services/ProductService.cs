namespace DependencyInjectionApp.Services;

using System.Threading.Tasks;
using DependencyInjectionApp.Models;
using DependencyInjectionApp.Repositories.Base;
using DependencyInjectionApp.Services.Base;

public class ProductService : IProductService
{
    private readonly IProductRepository productRepository;

    public ProductService(IProductRepository productRepository)
    {
        System.Console.WriteLine("Service CTOR");
        this.productRepository = productRepository;
    }

    public async Task CreateNewProductAsync(Product newProduct)
    {
        ArgumentNullException.ThrowIfNullOrEmpty(newProduct.Name);

        await this.productRepository.CreateAsync(newProduct);
    }
}