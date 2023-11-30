using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment_4_213034
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    ///

    public partial class MainWindow : Window
    {
        public class Person
        {
            private string _firstName;
            private string _lastName;

            public Person(string firstName, string lastName)
            {
                _firstName = firstName;
                _lastName = lastName;
            }
            public string FirstName => _firstName;
            public string LastName => _lastName;
        }

        public Person person { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            person = new Person("Muneeb", "Shahid");
            DataContext = this;
        }
    }
}

