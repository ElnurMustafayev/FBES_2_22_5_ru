namespace DependencyInjectionApp.Repositories.Base;

public interface IGetAllAsync<TEntity>
{
    Task<IEnumerable<TEntity>?> GetAllAsync();
}