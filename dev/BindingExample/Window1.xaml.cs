using System;
using System.Collections.Generic;
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
        private readonly Person _person = new Person {Name = "Ian", Age = 34, Address = "Hanoi"};

        public Window1()
        {
            InitializeComponent();

            this.DataContext = _person;
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"{_person.Name} is {_person.Age}");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _person.Age += 1;
        }
    }
}
