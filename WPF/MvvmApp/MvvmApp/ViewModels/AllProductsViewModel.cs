using MvvmApp.Models;
using MvvmApp.Repositories;
using MvvmApp.Repositories.Base;
using MvvmApp.ViewModels.Base;
using System.Collections.ObjectModel;

namespace MvvmApp.ViewModels
{
    public class AllProductsViewModel : ViewModelBase
    {
        private readonly IProductRepository productRepository;

        public ObservableCollection<Product> Products { get; set; }

        public AllProductsViewModel(IProductRepository productRepository)
        {
            this.productRepository = productRepository;


            this.Products = new ObservableCollection<Product>();

            this.RefreshAllProducts();
        }

        private void RefreshAllProducts()
        {
            this.Products.Clear();
            
            var result = this.productRepository.GetAll();

            foreach (var item in result)
            {
                this.Products.Add(item);
            }
        }
    }
}
