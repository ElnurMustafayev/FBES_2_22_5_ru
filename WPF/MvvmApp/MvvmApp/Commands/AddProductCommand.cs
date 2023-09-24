using MvvmApp.Models;
using MvvmApp.Repositories;
using System;
using System.Windows.Input;

namespace MvvmApp.Commands
{
    public class AddProductCommand : ICommand
    {
        private readonly Product product;

        public event EventHandler? CanExecuteChanged;

        public AddProductCommand(Product product)
        {
            this.product = product;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            Console.WriteLine("Command Execute");
            //new ProductRepository().Create(this.product);
        }
    }
}
