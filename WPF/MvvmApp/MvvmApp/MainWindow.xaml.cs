using MvvmApp.ViewModels;
using System.Windows;

namespace MvvmApp
{
    public partial class MainWindow : Window
    {
        private MainViewModel viewModel;

        public MainWindow()
        {
            InitializeComponent();

            this.viewModel = new MainViewModel();
            this.viewModel.ActiveViewModel = new AddProductViewModel();

            this.DataContext = this.viewModel;
        }

        private void HomeClick(object sender, RoutedEventArgs e) => this.viewModel.ActiveViewModel = new HomeViewModel();
        private void AddClick(object sender, RoutedEventArgs e) => this.viewModel.ActiveViewModel = new AddProductViewModel();
        private void AllClick(object sender, RoutedEventArgs e) => this.viewModel.ActiveViewModel = new AllProductsViewModel();
    }
}
