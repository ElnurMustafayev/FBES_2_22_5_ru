using ChainOfResponsibility.Handlers;

Handler1 handler1 = new Handler1();
Handler2 handler2 = new Handler2();

handler1.SetNext(handler2);
handler1.Handle(obj: 777);