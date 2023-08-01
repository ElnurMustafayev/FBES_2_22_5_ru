namespace MediatorApp.Classes;

using MediatorApp.Messages;
using MediatorApp.Messenger;

public class ClassB {
    private readonly Messenger messenger;

    public void Func() {
        //this.messenger.Send(
        //    key: "qwerty",
        //    message: 777);
    }

    public ClassB(Messenger messenger) {
        this.messenger = messenger;

        this.messenger.Subscribe<SayMessage>((message) => {
            if (message is SayMessage sayMessage) {
                Console.WriteLine($"{sayMessage.From}: '{sayMessage.Text}'");
            }
        });

        //this.messenger.Subscribe(
        //    key: "say hello!",
        //    action: (obj) => {
        //        Console.WriteLine(obj);
        //        Console.WriteLine("Hello from ClassB");
        //    });
    }
}