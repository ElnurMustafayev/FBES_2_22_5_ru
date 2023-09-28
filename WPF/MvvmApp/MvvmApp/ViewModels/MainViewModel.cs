using MvvmApp.Commands.Base;
using MvvmApp.Mediator.Base;
using MvvmApp.Messages;
using MvvmApp.Repositories;
using MvvmApp.ViewModels.Base;

namespace MvvmApp.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        #region Fields
        private bool flag = false;
        private readonly IMessenger messenger;


        private ViewModelBase activeViewModel;

        public ViewModelBase ActiveViewModel
        {
            get => activeViewModel;
            set => base.PropertyChangeMethod(out activeViewModel, value);
        }
        #endregion


        #region Commands

        private CommandBase homeCommand;
        public CommandBase HomeCommand => this.homeCommand ??= new CommandBase(
            execute: () => {
                this.ActiveViewModel = App.Container.GetInstance<HomeViewModel>();
                this.flag = !this.flag;
                },
            canExecute: () => true);

        private CommandBase addCommand;
        public CommandBase AddCommand => this.addCommand ??= new CommandBase(
            execute: () => this.ActiveViewModel = App.Container.GetInstance<AddProductViewModel>(),
            canExecute: () => true);

        private CommandBase allCommand;
        public CommandBase AllCommand => this.allCommand ??= new CommandBase(
            execute: () => this.ActiveViewModel = App.Container.GetInstance<AllProductsViewModel>(),
            canExecute: () => this.flag);

        #endregion

        public MainViewModel(IMessenger messenger)
        {
            this.messenger = messenger;



            this.messenger.Subscribe<NavigationMessage>((message) =>
            {
                if(message is NavigationMessage navigationMessage)
                {
                    this.ActiveViewModel = navigationMessage.DestinationViewModel;
                }
            });
        }
    }
}
