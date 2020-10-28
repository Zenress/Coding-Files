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

namespace Repitition
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {        
        public MainWindow()
        {
            InitializeComponent();
            
            string[] coloroptions = new string[] {"Blue","Red","Green","Yellow" };

            foreach (string coloroption in coloroptions)
            {
                boxen.Items.Add(coloroption);

            }
            if (KeyDown="")
            {

            }
            Title = windowtitle.Text;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double minimumnumber = double.Parse(Size2.Text);
            
            
            if (windows.Height > 10+minimumnumber)
            {
                windows.Height = windows.Height - 10;
                height.Content = windows.Height;
                windows.Width = windows.Width - 10;
                width.Content = windows.Width;               
            
            }               
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double minimumnumber = double.Parse(Size2.Text);


            if (windows.Height > minimumnumber)
            {
                windows.Height = windows.Height + 10;
                height.Content = windows.Height;
                windows.Width = windows.Width + 10;
                width.Content = windows.Width;            
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selected = (string)boxen.SelectedItem;

            switch (selected)
            {
                case "Blue":
                    windows.Background = Brushes.Blue;
                    break;

                case "Red":
                    windows.Background = Brushes.Red;
                    break;

                case "Green":
                    windows.Background = Brushes.Green;
                    break;

                case "Yellow":
                    windows.Background = Brushes.Yellow;
                    break;
                default:
                    break;
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
                                  
            
        }
    }
}
