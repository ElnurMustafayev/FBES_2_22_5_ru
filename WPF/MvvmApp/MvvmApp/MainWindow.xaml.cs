using MvvmApp.ViewModels;
using System.Windows;

namespace MvvmApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var viewModel = new MainViewModel();
            viewModel.ActiveViewModel = new HomeViewModel();

            this.DataContext = viewModel;
        }
    }
}
