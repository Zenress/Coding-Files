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
using System.Windows.Shapes;
using FornavnEfternavn.WpfItemsControls.Exercise1.Model;

namespace FornavnEfternavn.WpfItemsControls.Exercise1.Views
{
    /// <summary>
    /// Interaction logic for NewPerson.xaml
    /// </summary>
    public partial class NewPerson : Window
    {
        public NewPerson(ListBox people)
        {
            InitializeComponent();
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            Person newPerson = new Person(firstNameTB.Text, lastNameTB.Text, eMailTB.Text, tlfNrTB.Text);
            People.Items.Add(newPerson);
        }
    }
}
