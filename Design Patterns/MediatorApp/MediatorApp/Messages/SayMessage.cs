namespace MediatorApp.Messages;

using MediatorApp.Messages.Base;

public class SayMessage : IMessage {
    public string Title { get; set; }
    public string Text { get; set; }
    public string From { get; set; }

    public SayMessage(string title, string text, string from) {
        Title = title;
        Text = text;
        From = from;
    }
}