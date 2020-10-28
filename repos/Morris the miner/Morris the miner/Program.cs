using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morris_the_miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int sleepiness = 0, thirst = 0, hungry = 0, whiskey = 0, gold = 0;
            bool alive = true;
            //Possible combinations of states
            // Mining, Drink, Eat, Sleeping. Repeat
            //
            for (int i = 0; i < 1000; i++)
            {
                if (alive == true)
                {
                    //If statement for checking if morris is alive stil
                    if (sleepiness > 100 || thirst >100 || hungry >100 || whiskey >10 || sleepiness < 0 || thirst < 0 || hungry < 0 || whiskey < 0)
                    {
                        alive = false;
                        Console.WriteLine("\n R.I.P Morris \n");
                        break;                   
                    }                    
                    //If statements for determining which move to make
                    if (!(sleepiness > 90 || thirst > 90 || hungry > 90 || whiskey > 9))
                    {
                            //Mining
                            sleepiness += 5;
                            thirst += 5;
                            hungry += 5;                        
                            gold += 5;
                    }                         
                    else if(thirst > 90 && whiskey > 0)
                        {
                        //Drinking
                            sleepiness += 5;
                            thirst -= 15;
                            hungry -= 1;
                            whiskey -= 1;                        
                        }
                    else if (hungry >= 90 )
                        {
                            //Eat                        
                            sleepiness += 5;
                            thirst -= 5;
                            hungry -= 20;                    
                            gold -= 2;
                        }
                    else if (sleepiness > 90)
                        {
                            //Sleeping
                            sleepiness -= 10;
                            thirst += 1;
                            hungry += 1;
                            whiskey += 0;
                            gold += 0;                        
                        }
                    else if (whiskey < 1 )
                        {
                            //Shop4Whiskey
                            sleepiness += 5;
                            thirst += 1;
                            hungry += 1;
                            whiskey += 1;
                            gold -= 1;
                        }
                }
                //Printing the result after each one
            Console.WriteLine("Sleepiness: "+sleepiness+"  Thirst: "+thirst+"  Hunger: "+hungry+"  Whiskey:"+whiskey+"  Gold: "+gold);
                Console.WriteLine("Turns: "+i);      
            }
        }
    }
}
