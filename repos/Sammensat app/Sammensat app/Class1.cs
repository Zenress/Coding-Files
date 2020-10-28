using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sammensat_app
{
    public class Tama
    {
       public int tamaHealth, tamaHappiness, tamaHunger, tamaThirst;
        public bool tamaIsAlive;
        public DateTime Time;

        public Tama(int TamaHealth, int TamaHappiness, int TamaHunger, int TamaThirst, bool TamaIsAlive)
        {
            tamaHealth = TamaHealth;
            tamaHappiness = TamaHappiness;
            tamaHunger = TamaHunger;
            tamaThirst = TamaThirst;
            tamaIsAlive = TamaIsAlive;
            Time = DateTime.Now;
        }

       public void UpdateStats()
        {
            var dateNow = DateTime.Now;
            if (dateNow > (Time + new TimeSpan(0, 0, 6)))
            {
                int multiplier = (int)Math.Floor((dateNow - Time).TotalMilliseconds / 1000);
                multiplier -= multiplier % 4;
                multiplier /= 4;
                if (tamaHunger < 20 || tamaThirst < 20 || tamaHappiness <20)
                {
                    if (tamaHunger < 20 && tamaThirst < 20 || tamaHunger <20 && tamaHappiness <20 || tamaThirst <20 && tamaHappiness <20)
                    {
                        tamaHealth -= 8 * (200 - (tamaHunger + tamaThirst)) / 10;
                    }
                    if (tamaHunger <20 && tamaHappiness <20 && tamaThirst <20)
                    {
                        tamaHealth -= 12 * (200 - (tamaHunger + tamaThirst)) / 10;
                    }
                    else
                    {
                        tamaHealth -= 4 * (200 - (tamaHunger + tamaThirst)) / 10;
                    }
                    if (tamaHealth < 1)
                    {
                        tamaIsAlive = false;
                    }
                }
                if (tamaHealth > 1 && tamaHappiness > 0 && tamaHunger > 0 && tamaThirst > 0)
                {
                    tamaHappiness -= 1 * (5 /multiplier);
                    tamaHunger -= 1 * 3 / multiplier;
                    tamaThirst -= 1 * multiplier;
                }
               
                /*tamaHealth = (int)Math.Floor((dateNow - Time).TotalMilliseconds / 1000);
                */Time += dateNow.Subtract(Time);
                /*tamaHealth -= (int)(DateTime.Now - Time).TotalSeconds;*/
            }
            /*tamaHealth -= (int)Math.Floor(DateTime.Now.Subtract(Time).TotalSeconds);
            tamaHealth -= (int)Math.Floor(Time.Subtract(DateTime.Now).TotalSeconds);*/
        }
    }
}
