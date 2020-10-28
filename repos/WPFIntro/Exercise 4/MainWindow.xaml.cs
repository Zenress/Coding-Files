using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

namespace Exercise_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int totalPresses = 0;
        public int currentPresses = 0;
        public MainWindow()
        {
            InitializeComponent();            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            totalPresses++;
            currentPresses++;
            TotalPresses.Text = totalPresses.ToString();
            CurrentValue.Text = currentPresses.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            totalPresses++;
            currentPresses--;
            TotalPresses.Text = totalPresses.ToString();
            CurrentValue.Text = currentPresses.ToString();
        }
    }
}
