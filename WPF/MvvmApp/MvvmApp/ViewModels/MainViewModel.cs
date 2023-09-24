using MvvmApp.ViewModels.Base;

namespace MvvmApp.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private ViewModelBase activeViewModel;

        public ViewModelBase ActiveViewModel { 
            get => activeViewModel; 
            set => base.PropertyChangeMethod(out activeViewModel, value); 
        }
    }
}
