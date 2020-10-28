using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Huh_what;

namespace For_just_messing_about
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> ages = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10
            };

            foreach (int item in ages)
            {
                Console.WriteLine(ages.Count());
            }

            Car object1 = new Car();

            object1.Dyt();
            
            
        }
    }
}
