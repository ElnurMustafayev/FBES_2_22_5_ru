using DecoratorApp.Decorators;
using DecoratorApp.Notifiers;
using DecoratorApp.Notifiers.Base;

var notifier = new SmsNotifier();

Notifier decorator = new FacebookNotifierDecorator(notifier);
decorator = new SlackNotifierDecorator(decorator);
decorator = new SmsNotifierDecorator(decorator);

decorator.Send("Elnur", "Hello World!");