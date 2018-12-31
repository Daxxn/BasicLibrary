using System;
using System.Collections.Generic;
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
using BasicLibrary;

namespace BasicUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Person> allPeople = new List<Person>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Submit_Name_Click(object sender, RoutedEventArgs e)
        {
            allPeople.Add(new Person(First_Box.Text, Last_Box.Text));
        }

        private void Random_Num_Click(object sender, RoutedEventArgs e)
        {
            Random roll = new Random();
            MessageBox.Show(roll.Next(1, 100).ToString());
        }

        private void Show_Names_Click(object sender, RoutedEventArgs e)
        {
            //string allPersons = PrintNames(allPeople);
            MessageBox.Show(allPeople[0].FullName);
        }

        private string CombineNames(List<Person> people)
        {
            string allPeeps = "";
            foreach (var item in collection)
            {

            }
            
        }
    }
}
