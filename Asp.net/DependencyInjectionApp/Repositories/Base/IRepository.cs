namespace DependencyInjectionApp.Repositories.Base
{
    public interface IRepository
    {
        IEnumerable<object> GetAll();
        void Create(object obj);
        void Update(string id, object obj);
        void Delete(string id);
    }
}