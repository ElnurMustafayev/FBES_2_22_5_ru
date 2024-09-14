namespace ProductsWebApi.Repositories.Base;

using ProductsWebApi.Entities;

public interface IProductRepository
{
    public Task<Product?> GetAsync(int id);
}