using System;
using System.Windows.Input;

namespace MvvmApp.Commands.Base
{
    public class CommandBase : ICommand
    {
        private readonly Action execute;
        private readonly Func<bool> canExecute;

        public event EventHandler? CanExecuteChanged;

        public CommandBase(Action execute, Func<bool> canExecute)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public bool CanExecute(object? parameter)
        {
            return this.canExecute.Invoke();
        }

        public void Execute(object? parameter)
        {
            this.execute.Invoke();
        }
    }
}
