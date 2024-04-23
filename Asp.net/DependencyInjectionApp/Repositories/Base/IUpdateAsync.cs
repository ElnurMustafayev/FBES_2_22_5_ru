namespace DependencyInjectionApp.Repositories.Base;

public interface IUpdateAsync<TEntity, TId>
{
    Task UpdateAsync(TId id, TEntity obj);
}