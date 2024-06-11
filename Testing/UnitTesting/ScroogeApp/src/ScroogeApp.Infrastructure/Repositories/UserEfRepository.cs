using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ScroogeApp.Core.Models;
using ScroogeApp.Core.Repositories;
using ScroogeApp.Infrastructure.Data;

namespace ScroogeApp.Infrastructure.Repositories
{
    public class UserEfRepository : IUserRepository
    {
        private readonly MyDbContext dbContext;

        public UserEfRepository(MyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<User?> FindByName(string name)
        {
            User? user = await this.dbContext.Users.FirstOrDefaultAsync(u => u.Name == name);
            return user;
        }

        public async Task<IEnumerable<User>> FindInIdRange(long from, long to)
        {
            return await this.dbContext.Users
                .Where(u => u.Id >= from && u.Id <= to)
                .ToListAsync();
        }
    }
}