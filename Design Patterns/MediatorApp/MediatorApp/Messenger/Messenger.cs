using MediatorApp.Messages.Base;

namespace MediatorApp.Messenger;

public class Messenger {
    private Dictionary<Type, List<Action<IMessage>>> dict;

	public Messenger() {
        dict = new Dictionary<Type, List<Action<IMessage>>>();
    }

    public void Subscribe<T>(Action<IMessage> action) where T : IMessage {
        var type = typeof(T);

        if (dict.ContainsKey(type) == false)
            dict.Add(type, new List<Action<IMessage>>());

        dict[type].Add(action);
    }

    public void Send<T>(T message) where T : IMessage {
        var type = typeof(T);

        if (dict.ContainsKey(type) == false)
            return;

        foreach (var action in dict[type]) {
            action.Invoke(message);
        }
    }
}