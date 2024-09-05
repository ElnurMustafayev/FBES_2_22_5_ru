using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Options;
using RabbitMQ.Client;
using WebApi1.Options;
using WebApi1.Services.Base;

namespace WebApi1.Services
{
    public class RabbitMqService : IMessageBrokerService
    {
        private readonly ConnectionFactory rabbitMqConnectionFactory;

        public RabbitMqService(IOptionsSnapshot<RabbitMqOptions> optionsSnapshot)
        {
            this.rabbitMqConnectionFactory = new ConnectionFactory() {
                HostName = optionsSnapshot.Value.HostName,
                UserName = optionsSnapshot.Value.UserName,
                Password = optionsSnapshot.Value.Password
            };
        }

        public Task Push<T>(string destination, T obj)
        {
            using var connection = this.rabbitMqConnectionFactory.CreateConnection();
            using var channel = connection.CreateModel();

            var result = channel.QueueDeclare(
                queue: destination,
                durable: true,
                exclusive: false,
                autoDelete: false
            );

            var userJson = JsonSerializer.Serialize(obj);

            var messageInBytes = Encoding.UTF8.GetBytes(userJson);

            channel.BasicPublish(
                exchange: string.Empty,
                routingKey: destination,
                basicProperties: null,
                body: messageInBytes
            );

            return Task.CompletedTask;
        }
    }
}