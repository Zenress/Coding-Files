using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace Exercise_13
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {              
        public MainWindow()
        {            
            InitializeComponent();            
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            //Setting the textblock to nothing
            myBlock.Text = "";                      
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {            
            //Setting the textblock to check
            myBlock.Text = "Check!";            
        }

        private void myCheckBox_Click(object sender, RoutedEventArgs e)
        {
            //Setting the checkbox to maybe
            if (myCheckBox.IsChecked == null)
            {
                myBlock.Text = "Maybe";
            }
        }
    }
}
