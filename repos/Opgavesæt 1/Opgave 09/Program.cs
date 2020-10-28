using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_09
{
    class Program
    {
        static void Main(string[] args)
        {
          int a = 1;
          int b = 2;
          int c = 3;
          int x = 0;

            //X is 3
            /*if (a == 1)
            {
                x = 1;
            }
            if (b == 1)
            {
                x = 2;
            }
            if (c ==3)
            {
                x = 3;
            }*/

            //X is 3 (Wrong it is 2)
            /*if (a != 1)
            {
                x = 1;
            }
            else if (b == 2)
            {
                x = 2;
            }
            else if (c == 3)
            {
                x = 3;
            }*/

            //X is 0
            /*if (a == 2)
            {
                x = 1;
                if (b == 2)
                {
                    x = 2;
                }
            }
            else if (c == 1)
            {
                x = 3;
            }*/

            //X is 2
            if (a + b == b)
            {
                x = 1;
            }
            else
            {
                if (b - a == a)
                {
                    x = 2;
                }
                if (c - b == b)
                {
                    x = 3;
                }
            }
            Console.WriteLine(x);
        }
    }
}
