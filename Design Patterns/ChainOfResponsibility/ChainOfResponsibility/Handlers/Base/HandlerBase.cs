namespace ChainOfResponsibility.Handlers.Base;

public abstract class HandlerBase {
    protected HandlerBase? next;
    public abstract void Handle(object obj);
    public void SetNext(HandlerBase handler) => this.next = handler;
}