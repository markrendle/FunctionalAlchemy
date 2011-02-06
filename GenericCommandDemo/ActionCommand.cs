using System;
using System.Windows.Input;

namespace GenericCommandDemo
{
    public class ActionCommand : ICommand
    {
        private readonly Action<object> _execute;
        private readonly Func<object, bool> _canExecute;

        public ActionCommand(Action<object> execute)
            : this(execute, obj => true)
        {
        }

        public ActionCommand(Action<object> execute, Func<object, bool> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public ActionCommand(Action execute)
            : this(obj => execute())
        {
        }

        public ActionCommand(Action execute, Func<bool> canExecute)
            : this(obj => execute(), obj => canExecute())
        {
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute(parameter);
        }

        public event EventHandler CanExecuteChanged;
    }
}