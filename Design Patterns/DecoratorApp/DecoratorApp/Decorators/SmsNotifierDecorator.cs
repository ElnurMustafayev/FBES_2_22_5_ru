namespace DecoratorApp.Decorators;

using DecoratorApp.Decorators.Base;
using DecoratorApp.Notifiers;
using DecoratorApp.Notifiers.Base;

public class SmsNotifierDecorator : NotifierDecorator {
    private readonly SmsNotifier smsNotifier;
    public SmsNotifierDecorator(Notifier wrappee) : base(wrappee) {
        this.smsNotifier = new SmsNotifier();
    }

    public override void Send(string destination, string message) {
        Console.WriteLine($"-----{nameof(SmsNotifierDecorator)} start");
        base.Send(destination, message);

        this.smsNotifier.Send(destination, message);
        Console.WriteLine($"-----{nameof(SmsNotifierDecorator)} end");
    }
}