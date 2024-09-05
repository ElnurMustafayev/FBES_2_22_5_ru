using WebApi1.Entities;

namespace WebApi1.Services.Base;

public interface IUserService
{
    public Task<long> SignUp(User newUser);
}