using System;
using System.Windows.Input;

namespace GenericCommandDemo
{
    public class WholeClassForACommand : ICommand
    {
        private readonly MainViewModel _mainViewModel;

        public WholeClassForACommand(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
        }

        public void Execute(object parameter)
        {
            _mainViewModel.DisplayText = "A whole class! Just for this!";
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;
    }
}