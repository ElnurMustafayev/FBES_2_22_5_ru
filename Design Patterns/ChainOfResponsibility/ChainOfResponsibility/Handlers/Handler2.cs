namespace ChainOfResponsibility.Handlers;

using ChainOfResponsibility.Handlers.Base;

public class Handler2 : HandlerBase {
    public override void Handle(object obj) {
        Console.WriteLine($"Handler 2 {obj}");

        base.next?.Handle(obj);
    }
}