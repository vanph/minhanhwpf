using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BindingExample
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public ObservableCollection<Person> People { get; set; }
        public Window1()
        {
            InitializeComponent();

            var persons = new List<Person>
            {
                new Person {Name = "Ian", Age = 34, Address = "Hanoi"},
                new Person {Name = "Ian2", Age = 12, Address = "Saigon"},
                new Person {Name = "Ian3", Age = 45, Address = "Soc trang"},
                new Person {Name = "Ian4", Age = 65, Address = "Thai nguyen"},
                new Person {Name = "Ian5", Age = 76, Address = "Nam dinh"}
            };

            People = new ObservableCollection<Person>(persons);
            
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show($"{_person.Name} is {_person.Age}");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //_person.Age += 1;
        }
    }
}
