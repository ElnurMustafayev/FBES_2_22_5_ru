using MvvmApp.Messages.Base;
using MvvmApp.ViewModels;
using MvvmApp.ViewModels.Base;

namespace MvvmApp.Messages
{
    public class NavigationMessage : IMessage
    {
        public readonly ViewModelBase DestinationViewModel;

        public NavigationMessage(ViewModelBase destinationViewModel)
        {
            this.DestinationViewModel = destinationViewModel;
        }
    }
}
