namespace ScroogeApp.Infrastructure.Services;

using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ScroogeApp.Core.Exceptions;
using ScroogeApp.Core.Models;
using ScroogeApp.Core.Repositories;
using ScroogeApp.Core.Services;
using ScroogeApp.Infrastructure.Data;

public class UserService : IUserService
{
    private readonly MyDbContext dbContext;
    private readonly IUserRepository userRepository;

    public UserService(MyDbContext dbContext, IUserRepository userRepository)
    {
        this.userRepository = userRepository;
        this.dbContext = dbContext;
    }

    public async Task CreateUserAsync(User user)
    {
        await this.dbContext.Users.AddAsync(user);
        await this.dbContext.SaveChangesAsync();
    }

    public async Task<User> GetUserAsync(string username)
    {
        var user = await this.userRepository.FindByName(username);

        if(user is null) {
            throw new NotFoundException(entity: nameof(user));
        }

        return user;
    }

    public async Task<IEnumerable<User>> GetUsersOutOfEmbargo(long startId, long endId)
    {
        var users = await this.userRepository.FindInIdRange(startId, endId);

        return users.Where(u => u.IsInEmbargo == false);
    }
}