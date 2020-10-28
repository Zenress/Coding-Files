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

namespace Exercise_10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string passWord;
        public string brugerNavn;
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void logIn_Click(object sender, RoutedEventArgs e)
        {
            //Getting the values of the 2 boxes
            brugerNavn = BrugerNavn.Text;
            passWord = PassWord.Password;
                        
            //Checking the values against the known 2 combinations of logins
            if (brugerNavn == "Ole" && passWord == "MinHundErSød")
            {
                logInSucess.Content = "Du kan godt logge ind";
            }
            else if (brugerNavn == "Brian" && passWord == "LastBil2006$Rød")
            {
                logInSucess.Content = "Du kan godt logge ind";
            }
            //If you didn't type a valid password
            else
            {
                logInSucess.Content = "Du kan ikke logge ind";
            }
        }
    }
}
