namespace DecoratorApp.Notifiers.Base;

public abstract class Notifier {
    public abstract void Send(string destination, string message);
}