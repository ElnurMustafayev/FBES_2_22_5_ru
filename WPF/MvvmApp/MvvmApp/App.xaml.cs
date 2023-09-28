using MvvmApp.Mediator;
using MvvmApp.Mediator.Base;
using MvvmApp.Repositories;
using MvvmApp.Repositories.Base;
using MvvmApp.ViewModels;
using MvvmApp.ViewModels.Base;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MvvmApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Container Container { get; set; } = new Container();

        protected override void OnStartup(StartupEventArgs e)
        {
            this.RegisterContainer();

            this.Start<HomeViewModel>();

            base.OnStartup(e);
        }

        private void Start<T>() where T : ViewModelBase
        {
            var mainView = new MainWindow();
            var mainViewModel = Container.GetInstance<MainViewModel>();
            mainViewModel.ActiveViewModel = Container.GetInstance<T>();

            mainView.DataContext = mainViewModel;

            mainView.ShowDialog();
        }

        private void RegisterContainer()
        {
            Container.RegisterSingleton<IProductRepository, ProductDapperRepository>();
            Container.RegisterSingleton<IProductStatusRepository, ProductStatusDapperRepository>();
            Container.RegisterSingleton<IMessenger, Messenger>();

            Container.RegisterSingleton<HomeViewModel>();
            Container.RegisterSingleton<AddProductViewModel>();
            Container.RegisterSingleton<AllProductsViewModel>();
            Container.RegisterSingleton<MainViewModel>();

            Container.Verify();
        }
    }
}
