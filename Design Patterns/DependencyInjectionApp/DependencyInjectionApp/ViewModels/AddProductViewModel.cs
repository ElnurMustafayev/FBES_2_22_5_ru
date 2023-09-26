using DependencyInjectionApp.Repositories.Base;
using DependencyInjectionApp.ViewModels.Base;

namespace DependencyInjectionApp.ViewModels
{
    public class AddProductViewModel : ViewModelBase
    {
        private readonly IProductRepository productRepository;
        private readonly IProductStatusRepository productStatusRepository;

        public AddProductViewModel(IProductRepository productRepository, IProductStatusRepository productStatusRepository)
        {
            this.productRepository = productRepository;
            this.productStatusRepository = productStatusRepository;
        }
    }
}
