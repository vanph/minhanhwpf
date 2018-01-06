using System.ComponentModel;

namespace BindingExample
{
    public class Person : BasePropertyChange
    {
        public string Name { get; set; }

        public string Address { get; set; }

        private int _age; //backing field
        public int Age
        {
            get => _age;
            set
            {
                if (value != _age)
                {
                    _age = value;
                    RaisePropertyChanged(nameof(Age));
                }
            }
        }

       
    }
}
