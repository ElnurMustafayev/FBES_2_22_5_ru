using DependencyInjectionApp.Models;

namespace DependencyInjectionApp.Repositories.Base;

public interface IProductRepository
{
    Task<IEnumerable<Product>?> GetAllAsync();
}