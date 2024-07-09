namespace Cqrs.Repositories.Base
{
    public interface IDatabaseRepository
    {
        Task InitDbAsync();
    }
}