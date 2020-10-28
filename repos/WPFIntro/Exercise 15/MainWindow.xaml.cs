using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Exercise_15
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

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            //Uses the visibility property to make the radiobuttons invisible
            Red.Visibility = Visibility.Hidden;
            Green.Visibility = Visibility.Hidden;
            Yellow.Visibility = Visibility.Hidden;
        }

        private void RadioButton_Unchecked(object sender, RoutedEventArgs e)
        {
            //Uses the visibility property to make the radiobuttons visible again
            Red.Visibility = Visibility.Visible;
            Green.Visibility = Visibility.Visible;
            Yellow.Visibility = Visibility.Visible;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            //Uses the enabled property to disable the radiobuttons disabling the option to click them
            Red.IsEnabled = false;
            Green.IsEnabled = false;
            Yellow.IsEnabled = false;
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            //Uses the enabled property to enable the radiobuttons again allowing them to be used
            Red.IsEnabled = true;
            Green.IsEnabled = true;
            Yellow.IsEnabled = true;
        }
    }
}
