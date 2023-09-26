using MvvmApp.Repositories;
using MvvmApp.Repositories.Base;
using MvvmApp.ViewModels;
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
            Container.RegisterSingleton<IProductRepository, ProductDapperRepository>();
            Container.RegisterSingleton<IProductStatusRepository, ProductStatusDapperRepository>();

            Container.RegisterSingleton<HomeViewModel>();
            Container.RegisterSingleton<AddProductViewModel>();
            Container.RegisterSingleton<AllProductsViewModel>();
            Container.RegisterSingleton<MainViewModel>();

            Container.Verify();

            base.OnStartup(e);
        }
    }
}
