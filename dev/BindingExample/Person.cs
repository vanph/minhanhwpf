using System.ComponentModel;

namespace BindingExample
{
    public class Person : INotifyPropertyChanged
    {
        public string Name { get; set; }

        private decimal _ageValue;
        public decimal Age
        {
            get => _ageValue;
            set
            {
                if (value != _ageValue)
                {
                    _ageValue = value;
                    OnPropertyChanged("Age");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
