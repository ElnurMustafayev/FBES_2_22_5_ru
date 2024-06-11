using ScroogeApp.Core.Models;

namespace ScroogeApp.Core.Repositories
{
    public interface IUserRepository
    {
        public Task<User?> FindByName(string name);
        public Task<IEnumerable<User>> FindInIdRange(long from, long to);
    }
}