using System.ComponentModel;
using System.Windows.Input;

namespace GenericCommandDemo
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private readonly ICommand _demoCommand;
        private string _displayText;

        public MainViewModel()
        {
            _demoCommand = new ActionCommand(() => DisplayText = "Functional!");
        }

        public ICommand DemoCommand
        {
            get { return _demoCommand; }
        }

        public string DisplayText
        {
            get { return _displayText; }
            set
            {
                _displayText = value;
                PropertyChanged.Raise(this, "DisplayText");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}