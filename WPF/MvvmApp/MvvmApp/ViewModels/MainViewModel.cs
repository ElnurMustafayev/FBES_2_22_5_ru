using MvvmApp.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

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
