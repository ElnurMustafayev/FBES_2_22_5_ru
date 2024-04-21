namespace DependencyInjectionApp.Repositories;

using System.Text.Json;
using DependencyInjectionApp.Models;
using DependencyInjectionApp.Repositories.Base;

public class ProductJsonFileRepository : IProductRepository
{
    public async Task<IEnumerable<Product>?> GetAllAsync()
    {
        var json = await File.ReadAllTextAsync("./Assets/products.json");
        return JsonSerializer.Deserialize<IEnumerable<Product>>(json);
    }
}