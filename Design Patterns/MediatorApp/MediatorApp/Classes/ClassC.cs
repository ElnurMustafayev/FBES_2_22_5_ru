namespace MediatorApp.Classes;

using MediatorApp.Messages;
using MediatorApp.Messenger;

public class ClassC {
    private readonly Messenger messenger;
    public string Text { get; set; }
    public void Method() {
        //this.messenger.Send("say hello!", "qwerty");
        this.messenger.Send<SayMessage>(new SayMessage("test title", "something...", nameof(ClassC)));
    }

    public ClassC(Messenger messenger) {
        this.messenger = messenger;
    }
}