namespace DecoratorApp.Decorators;

using DecoratorApp.Decorators.Base;
using DecoratorApp.Notifiers;
using DecoratorApp.Notifiers.Base;

public class SlackNotifierDecorator : NotifierDecorator {
    private readonly SlackNotifier slackNotifier;
    public SlackNotifierDecorator(Notifier wrappee) : base(wrappee) {
        this.slackNotifier = new SlackNotifier();
    }

    public override void Send(string destination, string message) {
        Console.WriteLine($"-----{nameof(SlackNotifierDecorator)} start");
        base.Send(destination, message);

        this.slackNotifier.Send(destination, message);
        Console.WriteLine($"-----{nameof(SlackNotifierDecorator)} end");
    }
}