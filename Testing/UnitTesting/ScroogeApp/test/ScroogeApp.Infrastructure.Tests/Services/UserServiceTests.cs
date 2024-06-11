using ScroogeApp.Infrastructure.Services;
using Moq;
using ScroogeApp.Infrastructure.Repositories;
using ScroogeApp.Core.Repositories;
using ScroogeApp.Core.Models;
using ScroogeApp.Core.Exceptions;

namespace ScroogeApp.Infrastructure.Tests.Services
{
    public class UserServiceTests
    {
        [Fact]
        public async Task GetUserAsync_UserFound_DoesntThrowException()
        {
            Mock<IUserRepository> userRepositoryMock = new Mock<IUserRepository>();

            userRepositoryMock.Setup((repo) => repo.FindByName("bob"))
                .ReturnsAsync(new User() {
                    Name = "test"
                });

            var userService = new UserService(
                dbContext: null, 
                userRepository: userRepositoryMock.Object);

            await userService.GetUserAsync("bob");
        }

        [Fact]
        public async Task GetUserAsync_UserNotFound_ThrowsNotFoundException()
        {
            Mock<IUserRepository> userRepositoryMock = new Mock<IUserRepository>();

            userRepositoryMock.Setup((repo) => repo.FindByName("test"))
                .ReturnsAsync(value: null);

            var userService = new UserService(
                dbContext: null, 
                userRepository: userRepositoryMock.Object);

            await Assert.ThrowsAsync<NotFoundException>(async () => await userService.GetUserAsync("test"));
        }


        [Fact]
        public async Task GetUsersOutOfEmbargo_RepositoryReturnsUsersInAndOutOfEmbargo_ReturnsOnlyOutOfEmbargo() {
            var userOutOfEmbargo = new User() { IsInEmbargo = false };
            
            var users = new User[] {
                new User() { IsInEmbargo = true },
                new User() { IsInEmbargo = true },
                new User() { IsInEmbargo = true },
                userOutOfEmbargo,
                new User() { IsInEmbargo = true },
            };

            Mock<IUserRepository> userRepositoryMock = new Mock<IUserRepository>();

            userRepositoryMock.Setup(repo => repo.FindInIdRange(15, 20))
                .ReturnsAsync(users);
            
            var userService = new UserService(
                dbContext: null, 
                userRepository: userRepositoryMock.Object);

            var result = await userService.GetUsersOutOfEmbargo(15, 20);
            
            Assert.Single(result);
            Assert.Equal(userOutOfEmbargo, result.First());
        }
    }
}