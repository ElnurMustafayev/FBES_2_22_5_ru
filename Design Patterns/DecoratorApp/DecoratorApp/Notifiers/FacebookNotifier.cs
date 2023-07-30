namespace DecoratorApp.Notifiers;

using DecoratorApp.Notifiers.Base;

public class FacebookNotifier : Notifier {
    public override void Send(string destination, string message) {
        Console.WriteLine($"Facebook: {destination} => {message}");
    }
}