namespace DependencyInjectionApp.Repositories;

using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using DependencyInjectionApp.Models;
using DependencyInjectionApp.Repositories.Base;

public class ProductJsonFileRepository : IProductRepository
{
    private const string ProductsFilePath = "./Assets/products.json";
    
    public ProductJsonFileRepository()
    {
        System.Console.WriteLine("Repository CTOR");
    }
    
    public async Task CreateAsync(Product newProduct)
    {
        var json = await File.ReadAllTextAsync(ProductsFilePath);
        var allProducts = JsonSerializer.Deserialize<IEnumerable<Product>>(json) ?? Enumerable.Empty<Product>();

        var resultJson = JsonSerializer.Serialize(allProducts.Append(newProduct));

        await File.WriteAllTextAsync(ProductsFilePath, resultJson);
    }

    public async Task<IEnumerable<Product>?> GetAllAsync()
    {
        var json = await File.ReadAllTextAsync(ProductsFilePath);
        return JsonSerializer.Deserialize<IEnumerable<Product>>(json);
    }
}