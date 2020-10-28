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

namespace Exercise_5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Variables set before the program starts
        Random Pos = new Random();  
        public double margin1;
        public double margin2;
        public int buttonPressed = 0;
        public MainWindow()
        {
            InitializeComponent();            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Getting new random values for the margin1 and margin2
            margin1 = Pos.Next(100, 700);
            margin2 = Pos.Next(100, 700);
            //Making a margin variable
            Thickness margin = CatchMe.Margin;

            //Setting the margins
            margin.Left = margin1;
            margin.Top = margin2;
            margin.Right = 0;
            margin.Bottom = 0;

            //Setting the new values to the appropiate items
            CatchMe.Margin = margin;
            Score.Content = buttonPressed;
            buttonPressed++;
        }
    }
}
