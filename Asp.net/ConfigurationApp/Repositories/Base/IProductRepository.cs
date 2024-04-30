namespace ConfigurationApp.Repositories.Base;
public interface IProductRepository
{
    Task<long> GetMaxIdAsync();
}