namespace DependencyInjectionApp.Repositories.Base;

using DependencyInjectionApp.Models;

public interface IProductRepository : IGetAllAsync<Product>, ICreateAsync<Product> {}
public interface IProductRepository<TProduct> : IGetAllAsync<TProduct>, ICreateAsync<TProduct> where TProduct : Product {}