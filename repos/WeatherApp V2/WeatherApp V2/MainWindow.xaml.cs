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

namespace WeatherApp_V2
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

        private void InputField_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            WeatherAPI getwheater = new WeatherAPI();
            getwheater.getWeather(InputField.Text);
            TemperatureResult.Content = "Current: " + getwheater.temperature + " °C  Feels Like: " + getwheater.feelsLike + " °C";
            tempMinMax.Content = (getwheater.temperatureMin + " °C  ") + (getwheater.temperatureMax + " °C");
        }
    }
}
