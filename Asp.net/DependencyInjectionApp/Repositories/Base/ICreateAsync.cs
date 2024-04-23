namespace DependencyInjectionApp.Repositories.Base;

public interface ICreateAsync<TEntity>
{
    Task CreateAsync(TEntity obj);
}