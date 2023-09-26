using SimpleInjector;
using DependencyInjectionApp.Repositories;
using DependencyInjectionApp.ViewModels;
using DependencyInjectionApp.Repositories.Base;

namespace DependencyInjectionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleInjector.Container container = new Container();

            container.RegisterSingleton<IProductRepository, ProductDapperRepository>();
            container.RegisterSingleton<IProductStatusRepository, ProductStatusDapperRepository>();

            container.RegisterSingleton<AddProductViewModel>();
            container.RegisterSingleton<AllProductsViewModel>();

            container.Verify();



            Console.WriteLine(container.GetInstance<AddProductViewModel>().GetHashCode());
            Console.WriteLine(container.GetInstance<AddProductViewModel>().GetHashCode());
            Console.WriteLine(container.GetInstance<AddProductViewModel>().GetHashCode());



            //AddProductViewModel vm1 = new AddProductViewModel(new ProductDapperRepository(), new ProductStatusDapperRepository());
            //AllProductsViewModel vm2 = new AllProductsViewModel(new ProductDapperRepository());
        }
    }
}