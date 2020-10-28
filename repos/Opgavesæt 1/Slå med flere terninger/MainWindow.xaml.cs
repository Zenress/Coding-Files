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

namespace Slå_med_flere_terninger
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
                
        public MainWindow()
        {
            InitializeComponent();

            //For loop that adds the 10 items in the combobox
            for (int i = 1; i <= 10; i++)
            {
                Combobox.Items.Add(i);
            }
        }

        //A buttonclick event for running the dice
        private void Button_Click(object sender, RoutedEventArgs e)
        {   
            //Creating the random that is used to throw dices
            Random dicethrow = new Random();

            //Clearing the previous results so that it doesn't overwrite it
            results.Children.Clear();

            //For loop for creating a dice for the amount stated on the combobox, and then throwing it. Generating a random number
            for (int i = 0; i < (int)Combobox.SelectedItem; i++)
            {
                //Creating the label
                Label lbl = new Label();
                //Making the content in the label the number that the random decides
                lbl.Content = dicethrow.Next(1,7);
                //Setting the width on the created labels
                lbl.Width = 80;
                //Setting the height on the created labels
                lbl.Height = 80;
                //Setting the font size on the created labels
                lbl.FontSize = 30;
                //Setting the background color on the created labels
                lbl.Background = Brushes.Firebrick;
                //Setting the margins on the created labels
                lbl.Margin = new Thickness(5);
                //Setting the horizontal alignment on the created labels
                lbl.HorizontalContentAlignment = HorizontalAlignment.Center;
                //Setting the vertical alignment on the created labels
                lbl.VerticalContentAlignment = VerticalAlignment.Center;
                //Adding the created labels as children of the wrappanel
                results.Children.Add(lbl);
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
