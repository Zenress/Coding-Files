using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_and_if_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            bool looping = true;
            int number = 1;


            while (looping == true)
            {
                Console.WriteLine(number++);

                if (number == 1000)
                {
                    number = 1;
                    Console.Clear();
                }
            }
        }
    }
}
