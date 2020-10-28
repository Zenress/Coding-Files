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

namespace WPFGaming
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //All of the variables used for the calculations
        public int userChoice = 0;
        public int cpuChoice = 0;
        public bool cpuWon = false;
        public bool cpuLost = false;
        public int score = 0;
        List<int> Choice = new List<int>();
        Random cpuSelection = new Random();
        public MainWindow()
        {
            InitializeComponent();
            //Adds random items to the list
            for (int i = 0; i < 10; i++)
            {
                Choice.Add(cpuSelection.Next(1, 4));
            }
            //Sets the score for the label
            Score.Content = score;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Sets the chosen picture as the image shown for your choice
            userChoiceIMG.Source = new BitmapImage(new Uri("C:/Users/shan0382/Downloads/maxresdefault.jpg"));
            userChoice = 1;
            cpuChoices();           
            Score.Content = score;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Sets the chosen picture as the image shown for your choice
            userChoiceIMG.Source = new BitmapImage(new Uri("C:/Users/shan0382/Downloads/Cl4wptiWMAAdgCo.jpg"));
            userChoice = 2;
            cpuChoices();            
            Score.Content = score;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //Sets the chosen picture as the image shown for your choice
            userChoiceIMG.Source = new BitmapImage(new Uri("C:/Users/shan0382/Downloads/fuck_off.png"));
            userChoice = 3;
            cpuChoices();            
            Score.Content = score;
        }

        private void cpuChoices()
        {
            //Chooses a random item from the list
            cpuChoice = Choice[cpuSelection.Next(0,10)];
            scoring();
            //Painting an image depending on what choice the cpu has made
            if (cpuChoice == 1)
            {
                cpuChoiceIMG_Copy.Source = new BitmapImage(new Uri("C:/Users/shan0382/Downloads/maxresdefault.jpg"));
            }
            else if (cpuChoice == 2)
            {
                cpuChoiceIMG_Copy.Source = new BitmapImage(new Uri("C:/Users/shan0382/Downloads/Cl4wptiWMAAdgCo.jpg"));
            }
            else if (cpuChoice == 3)
            {
                cpuChoiceIMG_Copy.Source = new BitmapImage(new Uri("C:/Users/shan0382/Downloads/fuck_off.png"));
            }
            //Reverses the choice list if the cpu has won
            if (cpuWon == true && cpuLost == false)
            {
                Choice.Reverse();
            }
            //Reverses the first half of the list if the cpu has won
            else if (cpuLost == true && cpuWon == false)
            {
                Choice.Reverse(0,5);
            }            
        }
        private void combinations()
        {
            //The combinations of different choices and what will make you lose and what will make you win
            if (userChoice == 1 && cpuChoice == 2 || userChoice == 2 && cpuChoice == 3 || userChoice == 3 && cpuChoice == 1)
            {
                cpuWon = false;
                cpuLost = true;                
            }
            if (cpuChoice == 1 && userChoice == 2 || cpuChoice == 2 && userChoice == 3 || cpuChoice == 3 && userChoice == 1)
            {
                cpuLost = false;
                cpuWon = true;                
            }
            //If you chose the same as the cpu
            else if (cpuChoice == userChoice)
            {
                cpuLost = false;
                cpuWon = false;
            }
        }

        private void scoring()
        {
            //Using the combinations method and depending on what the boolean variables are set to. Add or subtract points
            combinations();
            if (cpuLost == true)
            {
                score++;
            }
            else if (cpuWon == true)
            {
                score--;
            }
            else if (cpuWon == false && cpuLost == false)
            {
                Score.Content = score;
            }
        }
    }
}
