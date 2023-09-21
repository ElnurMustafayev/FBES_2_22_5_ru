using MvvmApp.ViewModels;
using System.Windows;

namespace MvvmApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainViewModel viewModel;

        public MainWindow()
        {
            InitializeComponent();

            this.viewModel = new MainViewModel();
            this.viewModel.ActiveViewModel = new HomeViewModel();

            this.DataContext = this.viewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.viewModel.ActiveViewModel = this.viewModel.ActiveViewModel is HomeViewModel
                ? new AddProductViewModel()
                : new HomeViewModel();
        }
    }
}
