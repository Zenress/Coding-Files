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

namespace Exercise_14
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

        //Event for checking if the red box has been checked
        private void Red_Checked(object sender, RoutedEventArgs e)
        {
            //Changing the background color to red
            myWindow.Background = Brushes.Red;
        }

        //Event for checking if the yellow box has been checked
        private void Yellow_Checked(object sender, RoutedEventArgs e)
        {
            //Changing the background color to yellow
            myWindow.Background = Brushes.Yellow;
        }

        //Event for checking if the green box has been checked
        private void Green_Checked(object sender, RoutedEventArgs e)
        {
            //Changing the background color to Green
            myWindow.Background = Brushes.Green;
        }
    }
}
