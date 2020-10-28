using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 4;

            //Udsagn:

            //1.// True (Showed True)
            Console.WriteLine(a == b || a > 0);

            //2.// True (Showed True)
            Console.WriteLine(a + b > 0 && a > 0);

            //3.// True (Showed True)
            Console.WriteLine(a != 5 && a + b > 0);

            //4.// False (Showed False)
            Console.WriteLine((true || false) && a > b);

            //5.// False (Showed False)
            Console.WriteLine(3 > 5 && true || a == b);

            //6.//  False (Showed True)
            Console.WriteLine(b > a && true || false || b > 4);

            //7.// False (Showed True)
            Console.WriteLine(b < 4 && a < b || a + b > 4 && true);

            //8.// True (Showed True)
            Console.WriteLine(true && true || false);

            //9.// False (Showed False)
            Console.WriteLine(true && false && true);

            //10.// False (Showed True)
            Console.WriteLine(true || false || false);

            //11.// False (Showed False)
            Console.WriteLine(false && false);

            //12.// False (Showed True)
            Console.WriteLine(a == 3 && b > 4 || a + 3 > b);

            //13.// False (Showed False)
            Console.WriteLine(a > b && b < a && a + a == b);
        }
    }
}
