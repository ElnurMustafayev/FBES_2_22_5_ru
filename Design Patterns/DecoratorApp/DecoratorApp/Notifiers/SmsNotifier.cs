namespace DecoratorApp.Notifiers;

using DecoratorApp.Notifiers.Base;

public class SmsNotifier : Notifier {
    public override void Send(string destination, string message) {
        Console.WriteLine($"Sms: {destination} => {message}");
    }
}