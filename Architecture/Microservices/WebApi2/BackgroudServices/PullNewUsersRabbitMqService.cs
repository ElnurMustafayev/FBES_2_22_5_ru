using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Options;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using WebApi2.Entities;
using WebApi2.Options;

namespace WebApi2.BackgroudServices;

public class PullNewUsersRabbitMqService : IHostedService
{
    public static List<User> Users { get; set; }

    private readonly ConnectionFactory rabbitMqConnectionFactory;
    private readonly IConnection connection;
    private readonly IModel model;
    private const string QUEUE_NAME = "new_user";

    static PullNewUsersRabbitMqService() {
        Users = new List<User>();
    }

    public PullNewUsersRabbitMqService(IOptions<RabbitMqOptions> optionsSnapshot)
    {
        this.rabbitMqConnectionFactory = new ConnectionFactory()
        {
            HostName = optionsSnapshot.Value.HostName,
            UserName = optionsSnapshot.Value.UserName,
            Password = optionsSnapshot.Value.Password
        };

        this.connection = this.rabbitMqConnectionFactory.CreateConnection();
        this.model = connection.CreateModel();
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        var result = this.model.QueueDeclare(
            queue: QUEUE_NAME,
            durable: true,
            exclusive: false,
            autoDelete: false
        );

        var consumer = new EventingBasicConsumer(this.model);

        consumer.Received += (sender, deliverEventArgs) =>
        {
            string? newUserJson = null;

            try {
                newUserJson = Encoding.ASCII.GetString(deliverEventArgs.Body.ToArray());

                var newUser = JsonSerializer.Deserialize<User>(newUserJson)!;

                Users.Add(newUser);
            }
            catch(Exception ex) {
                System.Console.WriteLine($"Couldn't pull new user: '{ex}' | Body: {newUserJson}");
            }
        };

        this.model.BasicConsume(
            queue: QUEUE_NAME,
            autoAck: true,
            consumer: consumer
        );

        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}