using GettingStartedApp.Entities;
using GettingStartedApp.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace GettingStartedApp.Repositories;

public class UserEfCoreRepository : IUserRepository
{
    private readonly MyDbContext dbContext;

    public UserEfCoreRepository(MyDbContext dbContext) => this.dbContext = dbContext;
    public UserEfCoreRepository() => this.dbContext = new MyDbContext();

    public User Create(User user)
    {
        var created = this.dbContext.Users.Add(user);
        this.dbContext.SaveChanges();

        return user;
    }

    public void Delete(int id)
    {
        var userToDelete = this.dbContext.Users.FirstOrDefault(u => u.Id == id);

        if(userToDelete != null)
        {
            this.dbContext.Remove(userToDelete);
            this.dbContext.SaveChanges();
        }
    }

    public IEnumerable<User> GetAll()
    {
        return this.dbContext.Users.ToList();
    }

    public User GetById(int id) {
        return this.dbContext.Users.FirstOrDefault(u => u.Id == id, new NullUser());
    }

    public void Update(int id, User user)
    {
        if (user.Id == default)
            user.Id = id;

        this.dbContext.Users.Update(user);
        this.dbContext.SaveChanges();
    }
}