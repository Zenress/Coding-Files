using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
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
using System.Drawing;

namespace WPF_RPG_Spil
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {            
            double x = 0;
            double y = 0;
            InitializeComponent();

            Player player1 = new Player(100, 10, 10, 0, 0, 20);
            Rect playerPos = new Rect(Canvas.GetLeft(player), Canvas.GetTop(player), player.Width, player.Height);

            Monster myMonster = new Monster();            
            
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += new EventHandler(MovePlayer);            
            timer.Start();
            if (myMonster.createMonster(myCanvas).IntersectsWith(playerPos))
            {
                Detection.Content = "Detected";
            }
            else
            {
                Detection.Content = "No";
            }            

            void MovePlayer(object sender, EventArgs e)
            {
                yVariable.Content = y;
                xVariable.Content = x;
                if (Keyboard.IsKeyDown(Key.Left))
                {
                    x -= .3;
                    Canvas.SetLeft(player, x);
                }
                if (Keyboard.IsKeyDown(Key.Right))
                {
                    x += .3;
                    Canvas.SetLeft(player, x);
                }
                if (Keyboard.IsKeyDown(Key.Up))
                {
                    y -= .3;
                    Canvas.SetTop(player, y);
                }
                if (Keyboard.IsKeyDown(Key.Down))
                {
                    y += .3;
                    Canvas.SetTop(player, y);
                }
                if (y < 0)
                {
                    y += .3;
                    Canvas.SetTop(player, y);
                }
                if (x < 0)
                {
                    x += .3;
                    Canvas.SetLeft(player, x);
                }
                if (y > 380)
                {
                    y -= .3;
                    Canvas.SetTop(player, y);
                }
                if (x > 755)
                {
                    x -= .3;
                    Canvas.SetLeft(player, x);
                }
            }            
        }


        public class Player
        {
            
            int healthPoints;
            int strengthPoints;
            int agilityPoints;
            int experiencePoints;
            int lvlPoints;
            int defensePoints;
            bool isAlive = true;
            int playerChoice;
            
            public Player(int hp, int str, int agi, int xp, int lvl, int defense)
            {
                healthPoints = hp;
                strengthPoints = str;
                agilityPoints = agi;
                experiencePoints = xp;
                lvlPoints = lvl;
                defensePoints = defense;
            }
            public void choices()
            {
                switch (playerChoice)
                {
                    case 1:
                        healthPoints += 20;
                        break;
                    case 2:
                        strengthPoints += 10;
                        break;
                    case 3:
                        agilityPoints += 10;
                        break;
                    case 4:
                        defensePoints += 20;
                        break; 
                    default:
                        break;
                }
            }


            public void LevelUp(int xp, int lvl, bool Alive)
            {
                if(Alive == true)
                {
                    switch (xp)
                    {
                        case 10:
                            lvl = 1;
                            break;
                        case 25:
                            lvl = 2;
                            break;
                        case 50:
                            lvl = 3;
                            break;
                        case 100:
                            lvl = 4;
                            break;
                        case 150:
                            lvl = 5;
                            break;
                        case 215:
                            lvl = 6;
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        public class Monster
        {
            public double MonsterX;
            public double MonsterY;
            public double MonsterLeftSide;
            public double MonsterTopSide;
            Random rand = new Random();       
            
            public Rect createMonster(Canvas mycanvas)
            {
                Rectangle monster = new Rectangle
                {
                    Height = 30,
                    Width = 30,
                    Fill = Brushes.Green                    
                };
                MonsterX = rand.Next(0, 756);
                MonsterY = rand.Next(0, 381);
                Canvas.SetLeft(monster,MonsterX);
                Canvas.SetTop(monster, MonsterY);
                mycanvas.Children.Add(monster);
                Rect monsterPos = new Rect(Canvas.GetLeft(monster), Canvas.GetTop(monster), monster.Width, monster.Height);
                return monsterPos;
            }     
        }
        
    }
}
