using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Dungeon_Crawler_Fixed
{

    class Program
    {       
            static Random randomLvl = new Random();
            public static int levels = randomLvl.Next(1, 5);
        public static void highScore(Hero hero)
        {

            int newHighScore = hero.gold + hero.health + (hero.healthpotions * 100) + (hero.heroLevel * 100);
            StreamWriter File = new StreamWriter("HighScore.txt");

            File.Write("" + newHighScore);
            File.Close();
        }

        //Function used for fighting monsters
        public static void Fight(Hero hero, int levels)
        {
            //Randomizing Lvl for the monster and then spawning it
            
            Monster SpawnMonster = new Monster(levels + randomLvl.Next(1, 15),randomLvl.Next(1,11)); string happened = "";

            //Checking for the keyInput X.
            ConsoleKeyInfo key = new ConsoleKeyInfo(); while (key.KeyChar != 'x' && SpawnMonster.health > 0)
            {
                Console.Clear();
                Console.WriteLine("\n Hero:");
                Console.WriteLine(" Health: " + hero.health);
                Console.WriteLine(" Strength: "+ hero.strength);
                Console.WriteLine(" Magic: "+ hero.magic);
                Console.WriteLine(" Armor: "+ hero.armor);
                Console.WriteLine(" Gold: "+ hero.gold);
                Console.WriteLine(" Keys: " + hero.Lvlkey);
                Console.WriteLine("\n Monster:");
                Console.WriteLine(" Health: " + SpawnMonster.health + "%");                
                Console.WriteLine(" Strength: " + SpawnMonster.strength);
                Console.WriteLine(" MagicResist: " + SpawnMonster.magicResist);
                Console.WriteLine(" Armor: " + SpawnMonster.armor);
                Console.WriteLine(" Gold: " + SpawnMonster.gold);
                Console.WriteLine("\n");
                Console.WriteLine("" + happened); Console.WriteLine("\n");
                Console.WriteLine("(F) = Hit Monster");
                Console.WriteLine("(T) = Cast Spell On Monster");
                Console.WriteLine("(G) = Steal From Monster");
                Console.WriteLine("(H) = Drink Health Potion" + " " + hero.healthpotions);

                //Quits the fighting
                if (hero.health <= 0) { Console.Clear(); break; }
                key = Console.ReadKey();

                

                //The options for fighting
                switch (key.KeyChar)
                {
                    case 'f': 
                        SpawnMonster.health -= (int)(hero.strength - SpawnMonster.armor); 
                        hero.health -= (int)(SpawnMonster.strength - hero.armor); 
                        happened = "You hit the monster, but it hit you back";
                        if (SpawnMonster.health <= 0 && SpawnMonster.gold >= 15)
                            {
                                hero.gold = hero.gold + 10;
                            }
                        break;

                    case 'h':
                        if (hero.healthpotions >= 1)
                        {
                            happened = "You used a Health Potion. You feel Refreshed"; hero.health += 100; hero.healthpotions -= 1;
                        }
                        break;

                    case 'g':
                        if (SpawnMonster.gold > 10)
                        {
                            SpawnMonster.gold -= (int)(10); hero.gold += (int)(10);
                            hero.health -= (int)(SpawnMonster.strength - hero.armor);
                            happened = "You tryed to steal from the monster and found some gold but it hit you";

                            
                        }
                        else if (SpawnMonster.gold < 10)
                        {
                            happened = "You tried to steal from the monster but couldn't find any gold on it, but it hit you";
                            hero.health -= (int)(SpawnMonster.strength - hero.armor);
                        }
                        break;

                    case 't': 
                        SpawnMonster.health -= (int)(hero.magic + SpawnMonster.magicResist); 
                        hero.health -= (int)(SpawnMonster.strength - hero.armor); 
                        happened = "You cast a spell on the monster and it hit you back";
                        if (SpawnMonster.health <= 0 && SpawnMonster.gold >= 15)
                        {
                            hero.gold = hero.gold + 10;
                        }
                        break;

                }
                Console.Clear();
            }
        }

        public static void printMap(int[,] maze, int hX, int hY, Hero hero)
        {
            char c = ' ';
            for (int y = 0; y < maze.GetLength(0); y++)
            {
                Console.Write("\n ");
                for (int x = 0; x < maze.GetLength(1); x++)
                {
                    if (x == hX && y == hY)
                    {
                        Console.Write((char)2);
                    }
                    else
                    {
                        switch (maze[y, x])
                        {
                            case 0: c = ' '; break;
                            case 1: c = '#'; break;
                            case 2: c = '@'; break;
                            case 3: c = '%'; break;
                            case 4: c = '*'; break;
                            case 5: c = ' '; break;
                            case 6: c = ' '; break;
                        }
                        Console.Write(c);
                    }
                }
            }
            Console.WriteLine("\n\n");
            Console.WriteLine(" Options           Level:" + hero.heroLevel);
            Console.WriteLine(" A = Move Left | D = Move Right");
            Console.WriteLine(" S = Move Down | W = Move Up");
            Console.Write(" Hero Stats: \n" + " Strength: " + hero.strength + " " + "Health: " + hero.health);
            Console.WriteLine("\n" + " Gold: " + hero.gold + " Press b to buy a level for 100 Gold");
            Console.WriteLine("\n " + " ? = player // # = wall // @ = healthpotion // % = key // * = locked door ");
            Console.WriteLine("\n");
            Console.WriteLine(" X To Exit Game");
        }

        static void Main(string[] args)
        {            
            Hero hero = new Hero();
            int heroX = 1; int heroY = 1;
            int[,] maze =
            {
                //Array for the map. Changing it will change the map
                { 1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1, },
                { 1,0,1,6,0,0,0,0,0,0,0,6,0,0,0,0,0,0,6,1, },
                { 1,0,1,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,1, },
                { 1,0,1,0,1,1,0,0,0,0,0,0,0,1,0,0,0,1,0,1, },
                { 1,6,0,0,2,1,0,1,1,1,1,1,0,1,0,1,0,1,0,1, },
                { 1,1,1,1,1,1,0,1,0,6,0,1,0,0,0,1,2,0,0,1, },
                { 1,0,0,0,0,1,0,1,0,1,0,1,1,1,1,1,1,1,1,1, },
                { 1,0,1,1,0,0,0,1,0,1,0,1,1,1,1,1,0,0,0,1, },
                { 1,6,1,1,2,1,6,0,0,1,0,0,0,6,0,0,0,1,6,1, },
                { 1,3,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,1, },
                { 1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,1, },
                { 1,0,0,0,0,0,0,0,6,0,0,0,0,0,0,0,0,0,0,1, },
                { 1,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1, },
                { 1,0,1,6,0,0,0,0,0,0,0,6,0,0,0,0,0,0,6,1, },
                { 1,0,1,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,1, },
                { 1,0,1,0,1,1,0,0,0,0,0,0,0,1,0,0,0,1,0,1, },
                { 1,6,0,0,2,1,0,1,1,1,1,1,0,1,0,1,0,1,0,1, },
                { 1,1,1,1,1,1,0,1,0,6,0,1,0,0,0,1,2,0,0,1, },
                { 1,0,0,0,0,1,0,1,0,1,0,1,1,1,1,1,1,1,1,1, },
                { 1,0,1,1,0,0,0,1,0,1,0,1,1,1,1,1,0,0,0,1, },
                { 1,6,1,1,2,1,6,0,0,1,0,0,0,6,0,0,0,1,6,1, },
                { 1,3,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,4,1, },
                { 1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,5,1, },
            }; 
            while (true)
            {
                Console.Clear(); 
                //If statement containing the placement of the monsters
                if (maze[heroY, heroX] == 6)
                {
                    Fight(hero, levels); maze[heroY, heroX] = 0;
                }
                //If statement containing the placement of the healthpotions
                if (maze[heroY, heroX] == 2)
                {
                    hero.healthpotions += 1; maze[heroY, heroX] = 0;
                }
                //If statement containing the key the hero needs to get
                if (maze[heroY, heroX] == 3)
                {
                    hero.Lvlkey += 1; maze[heroY, heroX] = 0;
                }
                //If statement for determining when you have won the game
                if (maze[heroY, heroX] == 4 && hero.Lvlkey == 2)
                {
                    Console.Clear();
                    Console.WriteLine("You Won The Game!");
                    Console.WriteLine("Your Score has ben saved to your binFolder");
                    Console.WriteLine("Press Enter to exit"); 
                    highScore(hero);
                    Console.ReadLine(); 
                    break;
                }
                else if (maze[heroY, heroX] == 4 && hero.Lvlkey <= 1)
                {
                    Console.Clear();
                    Console.WriteLine("You cannot enter here, you don't have 2 keys");
                    Console.WriteLine("Press any key to continue the game");
                    Console.ReadKey();                    
                    heroY--;
                    break;
                }
                //If statement for determining if you are dead
                if (hero.health <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("\n The Monster Killed you!");
                    Console.WriteLine("You Lost The GAME!");
                    Console.WriteLine("\n Press Enter To Exit");
                    Console.ReadLine(); 
                    break;
                }
                //Updating the map according to the keys pressed
                printMap(maze, heroX, heroY, hero); 
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.KeyChar == 'w' && maze[heroY - 1, heroX] != 1 && maze[heroY + 1, heroX]
                != 5) heroY--;
                if (key.KeyChar == 'a' && maze[heroY, heroX - 1] != 1 && maze[heroY + 1, heroX]
                != 5) heroX--;
                if (key.KeyChar == 's' && maze[heroY + 1, heroX] != 1 && maze[heroY + 1, heroX]
                != 5) heroY++;
                if (key.KeyChar == 'd' && maze[heroY, heroX + 1] != 1 && maze[heroY + 1, heroX]
                != 5) heroX++;
                if (key.KeyChar == 'b' && hero.gold >= 100) { hero.gold -= 100; hero.heroLevel++; hero.UPDATEHERO(); }
                if (key.KeyChar == 'x') break;
            }
        }
    }

    //the Hero class is the player and contains the leveling
    class Hero
    {
        public int health; 
        public int strength; 
        public int magic; 
        public int armor; 
        public int healthpotions; 
        public int Lvlkey; 
        public int gold; 
        public int heroLevel = 1;

        //Function for holding the hero stats and updating them
        public void UPDATEHERO()
        {
            magic = 25 * heroLevel; 
            health = 210 + heroLevel * 10; 
            strength = 15 * heroLevel;
        }

        public Hero()
        {
            UPDATEHERO();
            armor = 5; healthpotions = 1; gold = 1000;
        }
    }

    //the Monster class is the class that contains the monster
    class Monster
    {
        public int health; 
        public int strength; 
        public int armor; 
        public int gold;
        public int magicResist;
        public string monsterName;
        public Random randomName = new Random();
        public Monster(int level, int monsterNumber)
        {
            health = 100; 
            strength = 1 * level; 
            armor = 2 + level; 
            gold = 2 * level; 
            magicResist = 30 + (level) * (2);                       
            switch (monsterNumber)
            {
                case 1:
                    monsterName = "LizardMan Richard";
                    break;
                case 2:
                    monsterName = "Legendary Dragon IveFallenAndICantGetUp";
                    break;
                case 3:
                    monsterName = "Ronald Mcdonald";
                    break;
                case 4:
                    monsterName = "Your Neighbourhood Drunk Knight";
                    break;
                case 5:

                    break;
                case 6:

                    break;
                case 7:

                    break;
                case 8:

                    break;
                case 9:

                    break;
                case 10:

                    break;

                default:
                    break;
            }
        }

    }
}
