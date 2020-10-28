using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

namespace WebAPI_WeatherApp
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

        //Submit button for showing you the temperature of the inputted city
        private void submitBtn_Click(object sender, RoutedEventArgs e)
        {
            //Creating a new instance of WheaterData Class
            WheaterData wheater = new WheaterData();
            //Using the getwheater method of the WheaterData Class
            wheater.GetWheater(cityInput.Text);

            //Replacing the result labels text with the result of the GetWheather method, and then checking if the method has failed, to account for failure.
            Result.Content = wheater.temperature + " °C";
            if (wheater.failed == true)
            {
                Result.Content = "City not found";
            }
        }
    }
}
