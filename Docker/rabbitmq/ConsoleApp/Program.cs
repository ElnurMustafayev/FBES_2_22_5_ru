using System.Text;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

void PushMessage(string message, string queueName) {
    var factory = new ConnectionFactory() {
        HostName = "localhost",
        UserName = "rmuser",
        Password = "rmpassword"
    };

    using var connection = factory.CreateConnection();
    using var channel = connection.CreateModel();

    var result = channel.QueueDeclare(
        queue: queueName,
        durable: true,
        exclusive: false,
        autoDelete: false
    );

    var messageInBytes = Encoding.ASCII.GetBytes(message);

    channel.BasicPublish(
        exchange: string.Empty,
        routingKey: queueName,
        basicProperties: null,
        body: messageInBytes
    );

    System.Console.WriteLine($"Push: '{message}'");
}

void PullMessage(string queueName) {
    var factory = new ConnectionFactory() {
        HostName = "localhost",
        UserName = "rmuser",
        Password = "rmpassword"
    };

    using var connection = factory.CreateConnection();
    using var channel = connection.CreateModel();

    var result = channel.QueueDeclare(
        queue: queueName,
        durable: true,
        exclusive: false,
        autoDelete: false
    );

    var consumer = new EventingBasicConsumer(channel);

    consumer.Received += (sender, deliverEventArgs) => {
        var message = Encoding.ASCII.GetString(deliverEventArgs.Body.ToArray());
        
        System.Console.WriteLine($"Pull: '{message}'");
    };

    channel.BasicConsume(
        queue: queueName,
        autoAck: true,
        consumer: consumer
    );

    Console.ReadKey();
}



var timer = new Timer(state => PushMessage("Test", "timer"), null, 0, 10);
Console.ReadKey();

PullMessage("timer");