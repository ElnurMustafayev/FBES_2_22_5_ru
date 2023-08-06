namespace ChainOfResponsibility.Handlers;

using ChainOfResponsibility.Handlers.Base;

public class Handler1 : HandlerBase {
    public override void Handle(object obj) {
        Console.WriteLine($"Handler 1 {obj}");

        if ((int)obj == 777)
            return;

        base.next?.Handle(obj);
    }
}