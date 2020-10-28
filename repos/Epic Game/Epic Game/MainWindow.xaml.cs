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
using System.Windows.Threading;

namespace Epic_Game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>    
    public partial class MainWindow : Window
    {        
        double Speed = .3;
        public double x;
        public double y;
        int score;
        public MainWindow()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            Food food = new Food();     
            Rectangle[] allFood = food.foodSpawn(myCanvas);            
            
            timer.Tick += new EventHandler(MovePlayer);
            timer.Tick += new EventHandler(foodDropping);            
            timer.Start();
            
            void foodDropping(object sender, EventArgs e)
            {
                y += .05;
                Canvas.SetTop(allFood[0], y);
                Canvas.SetTop(allFood[1], y);
                Canvas.SetTop(allFood[2], y);
                Canvas.SetTop(allFood[3], y);
                Canvas.SetTop(allFood[4], y);
                Canvas.SetTop(allFood[5], y);
                Canvas.SetTop(allFood[6], y);
                Canvas.SetTop(allFood[7], y);
                Canvas.SetTop(allFood[8], y);
                Canvas.SetTop(allFood[9], y);
            }
            void MovePlayer(object sender, EventArgs e)
            {
                if (Keyboard.IsKeyDown(Key.Left))
                {
                    x -= Speed;
                    Canvas.SetLeft(Player, x);
                }            
                if (Keyboard.IsKeyDown(Key.Right))
                {
                    x += Speed;
                    Canvas.SetLeft(Player, x);
                }
                void HitDetection()
                {
                    for (int i = 0; i < allFood.Length; i++)
                    {
                        if (Player.)
                        {
                            score++;
                            Score.Content = score;
                        }
                    }
                }
            }
        }

        public class Food
        {
            Random pos = new Random();
            public double x;
            public int increment = 0;
            public Rectangle[] foodSpawn(Canvas myCanvas)
            {
                Rectangle[] allFood = new Rectangle[10];                
                for (int i = 0; i < allFood.Length; i++)
                {
                    allFood[i] = new Rectangle
                    {
                        Width = 30,
                        Height = 30,
                        Fill = Brushes.Green,                 
                    };                    
                    myCanvas.Children.Add(allFood[i]);
                    x = pos.Next(100, 401);
                    Canvas.SetLeft(allFood[i], x);                    
                }
                return allFood;
            }
        }
        public class Eater
        {           
            
        }    
    }

}
