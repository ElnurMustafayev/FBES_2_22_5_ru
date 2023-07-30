namespace DecoratorApp.Decorators;

using DecoratorApp.Decorators.Base;
using DecoratorApp.Notifiers;
using DecoratorApp.Notifiers.Base;

public class FacebookNotifierDecorator : NotifierDecorator {
    private readonly FacebookNotifier facebookNotifier;
    public FacebookNotifierDecorator(Notifier wrappee) : base(wrappee) {
        facebookNotifier = new FacebookNotifier();
    }

    public override void Send(string destination, string message) {
        Console.WriteLine($"-----{nameof(FacebookNotifierDecorator)} start");
        base.Send(destination, message);

        this.facebookNotifier.Send(destination, message);
        Console.WriteLine($"-----{nameof(FacebookNotifierDecorator)} end");
    }
}