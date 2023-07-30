namespace DecoratorApp.Decorators.Base;

using DecoratorApp.Notifiers.Base;

public class NotifierDecorator : Notifier {
    private Notifier wrappee;

    public NotifierDecorator(Notifier wrappee) {
        this.wrappee = wrappee;
    }

    public override void Send(string destination, string message) {
        this.wrappee.Send(destination, message);
    }
}