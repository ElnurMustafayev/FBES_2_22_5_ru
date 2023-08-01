namespace MediatorApp.Classes;

using MediatorApp.Messages;
using MediatorApp.Messenger;

public class ClassA {
	private readonly Messenger messenger;

	public int Num { get; set; }

	public ClassA(Messenger messenger) {
		this.messenger = messenger;

        this.messenger.Subscribe<SayMessage>((message) => {
            if (message is SayMessage sayMessage) {
                Console.WriteLine($"{sayMessage.From}: {sayMessage.Title}");
                Console.WriteLine(sayMessage.Text);
            }
        });



        //this.messenger.Subscribe(
        //	key: "changeNum",
        //	action: (obj) => {
        //		this.Num = (obj is int num) ? num : -1;
        //	});

        //      this.messenger.Subscribe(
        //          key: "say hello!",
        //          action: (obj) => {
        //		Console.WriteLine($"Hello from ClassA. Message: '{obj}'");
        //          });
    }
}