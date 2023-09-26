using DependencyInjectionApp.Repositories.Base;
using DependencyInjectionApp.ViewModels.Base;

namespace DependencyInjectionApp.ViewModels
{
    public class AllProductsViewModel : ViewModelBase
    {
        private readonly IProductRepository productRepository;
        public AllProductsViewModel(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
    }
}
