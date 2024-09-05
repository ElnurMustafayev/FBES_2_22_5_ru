using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Options;
using RabbitMQ.Client;
using WebApi1.Entities;
using WebApi1.Options;
using WebApi1.Services.Base;

namespace WebApi1.Services
{
    public class UserService : IUserService
    {
        private readonly IMessageBrokerService messageBroker;

        public UserService(IMessageBrokerService messageBroker)
        {
            this.messageBroker = messageBroker;
        }

        public Task<long> SignUp(User newUser)
        {
            var result = Random.Shared.NextInt64(1000,10000);
            return Task.FromResult(result);
        }
    }
}