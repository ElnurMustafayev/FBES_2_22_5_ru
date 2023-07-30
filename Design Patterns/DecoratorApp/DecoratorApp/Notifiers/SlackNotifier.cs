namespace DecoratorApp.Notifiers;

using DecoratorApp.Notifiers.Base;

public class SlackNotifier : Notifier {
    public override void Send(string destination, string message) {
        Console.WriteLine($"Slack: {destination} => {message}");
    }
}