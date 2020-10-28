using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_2
{
    class Program
    {
        public int sleepiness = 0, thirst = 0, hungry = 0, whiskey = 0, gold = 0;
        void Main(string[] args)
        {
            if (sleepiness > 100 || thirst > 100 || hungry > 100 || whiskey > 10 || sleepiness < 0 || thirst < 0 || hungry < 0 || whiskey < 0)
            {
                miningaction();
            }
        }
        public void miningaction()
        {
            sleepiness += 5;
            thirst += 5;
            hungry += 5;
            gold += 5;
        }

        public void sleepingaction()
        {
            sleepiness -= 10;
            thirst += 1;
            hungry += 1;
            whiskey += 0;
            gold += 0;
        }

        public void thirstaction()
        {
            sleepiness += 5;
            thirst -= 15;
            hungry -= 1;
            whiskey -= 1;
        }

        public void hungryaction()
        {
            sleepiness += 5;
            thirst -= 5;
            hungry -= 20;
            gold -= 2;
        }

        public void whiskyaction()
        {
            sleepiness += 5;
            thirst += 1;
            hungry += 1;
            whiskey += 1;
            gold -= 1;

        }
    }
}
