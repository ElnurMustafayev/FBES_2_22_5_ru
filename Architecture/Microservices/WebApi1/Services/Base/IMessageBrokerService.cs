namespace WebApi1.Services.Base;

public interface IMessageBrokerService
{
    public Task Push<T>(string destination, T obj);
}