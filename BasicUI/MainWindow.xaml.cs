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
            Person person = new Person(First_Box.Text, Last_Box.Text);
            allPeople.Add(person);
            Person_Combo_Box.Items.Add(person);
            if (Name_List.Text != "")
            {
                Name_List.Text += "\n" + person;
            } else
            {
                Name_List.Text += person;
            }
            
        }

        private void Random_Num_Click(object sender, RoutedEventArgs e)
        {
            Random roll = new Random();
            //MessageBox.Show(roll.Next(1, 100).ToString());
            Dis_Random_Num.Text = roll.Next(1, 100).ToString();
        }

        private void Show_Names_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(allPeople[0].FullName);
            MessageBox.Show(CombineNames(allPeople));
        }

        private string CombineNames(List<Person> people)
        {
            string[] allArray = new string[people.Count];
            for (int i = 0; i < people.Count; i++)
            {
                if(people[i] != null)
                {
                    allArray[i] = people[i].FullName;
                }
            }
            string allPeeps = "";
            foreach (var peeps in people)
            {
                allPeeps += (allPeeps == "" ? "" : "\n") + peeps.FullName;
            }
            return allPeeps;
        }
    }
}
