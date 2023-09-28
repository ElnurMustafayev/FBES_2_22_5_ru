using MvvmApp.Commands;
using MvvmApp.Commands.Base;
using MvvmApp.Mediator.Base;
using MvvmApp.Messages;
using MvvmApp.Models;
using MvvmApp.Repositories;
using MvvmApp.Repositories.Base;
using MvvmApp.ViewModels.Base;
using System;
using System.Collections.ObjectModel;
using System.Threading;
using System.Windows;

namespace MvvmApp.ViewModels
{
    public class AddProductViewModel : ViewModelBase
    {
        private readonly IProductRepository productRepository;
        private readonly IProductStatusRepository productStatusRepository;
        private readonly IMessenger messenger;

        public ObservableCollection<ProductStatus> ProductStatuses { get; set; }



        private decimal? price;

        public decimal? Price
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




        private ProductStatus? selectedProductStatus;
        public ProductStatus? SelectedProductStatus
        {
            get { return selectedProductStatus; }
            set { base.PropertyChangeMethod(out selectedProductStatus, value); }
        }

        private CommandBase testCommand;

        public CommandBase TestCommand => testCommand ??= new CommandBase(
            execute: () =>
            {
                Console.WriteLine("TestCommand!");
            }, 
            canExecute: () => true);





        private CommandBase? addProductCommand;
        public CommandBase AddProductCommand => this.addProductCommand ??= new CommandBase(
                execute: () =>
                {
                    try
                    {
                        this.productRepository.Create(new Product()
                        {
                            Name = this.Name,
                            Price = this.Price,
                            Status = this.SelectedProductStatus?.Id
                        });
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }

                    this.Name = string.Empty;
                    this.Price = null;
                    this.SelectedProductStatus = null;

                    //App.Container.GetInstance<MainViewModel>().ActiveViewModel = App.Container.GetInstance<AllProductsViewModel>();

                    this.messenger.Send(new NavigationMessage(App.Container.GetInstance<AllProductsViewModel>()));
                },
                canExecute: () => true
            );


        public AddProductViewModel(IProductRepository productRepository, IProductStatusRepository productStatusRepository, IMessenger messenger)
        {
            this.productRepository = productRepository;
            this.productStatusRepository = productStatusRepository;
            this.messenger = messenger;

            var allProductStatuses = this.productStatusRepository.GetAll();
            this.ProductStatuses = new ObservableCollection<ProductStatus>(allProductStatuses);
        }
    }
}
