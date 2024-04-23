using DependencyInjectionApp.Models;

namespace DependencyInjectionApp.Services.Base
{
    public interface IProductService
    {
        public Task CreateNewProductAsync(Product newProduct);
    }
}