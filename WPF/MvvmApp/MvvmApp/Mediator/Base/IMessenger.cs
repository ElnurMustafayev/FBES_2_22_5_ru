using MvvmApp.Messages.Base;
using System;

namespace MvvmApp.Mediator.Base
{
    public interface IMessenger
    {
        void Subscribe<T>(Action<IMessage> action) where T : IMessage;
        void Send<T>(T message) where T : IMessage;
    }
}
