using MvvmApp.Commands;
using MvvmApp.Commands.Base;
using MvvmApp.Models;
using MvvmApp.Repositories;
using MvvmApp.ViewModels.Base;
using System;
using System.Collections.ObjectModel;
using System.Threading;

namespace MvvmApp.ViewModels
{
    public class AddProductViewModel : ViewModelBase
    {
        public ObservableCollection<ProductStatus> ProductStatuses { get; set; }



        private decimal price;

        public decimal Price
        {
            get => price;
            set => base.PropertyChangeMethod(out price, value);
        }




        private string name;

        public string Name
        {
            get => name;
            set => base.PropertyChangeMethod(out name, value);
        }




        private ProductStatus selectedProductStatus;
        public ProductStatus SelectedProductStatus
        {
            get { return selectedProductStatus; }
            set { base.PropertyChangeMethod(out selectedProductStatus, value); }
        }




        private CommandBase addProductCommand;
        public CommandBase AddProductCommand
        {
            get
            {
                if (addProductCommand == null)
                    addProductCommand = new CommandBase(
                        execute: () =>
                        {
                            var productRepository = new ProductRepository();
                            productRepository.Create(new Product()
                            {
                                Name = this.Name,
                                Price = this.Price,
                                Status = this.SelectedProductStatus?.Id
                            });
                        },
                        canExecute: () => true
                    );

                return addProductCommand;
            }
        }


        public AddProductViewModel()
        {
            var productStatusRepository = new ProductStatusRepository();

            var allProductStatuses = productStatusRepository.GetAll();

            this.ProductStatuses = new ObservableCollection<ProductStatus>(allProductStatuses);
        }


    }
}
