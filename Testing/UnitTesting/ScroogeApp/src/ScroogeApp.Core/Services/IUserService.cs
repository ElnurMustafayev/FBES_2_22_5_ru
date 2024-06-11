using ScroogeApp.Core.Models;

namespace ScroogeApp.Core.Services;

public interface IUserService
{
    public Task<User> GetUserAsync(string username);
    public Task CreateUserAsync(User user);
    public Task<IEnumerable<User>> GetUsersOutOfEmbargo(long startId, long endId);
}
