using GettingStartedApp.Entities;

namespace GettingStartedApp.Repositories.Base
{
    public interface IUserRepository
    {
        public User Create(User user);
        public IEnumerable<User> GetAll();
        public User GetById(int id);
        public void Update(int id, User user);
        public void Delete(int id);
    }
}
