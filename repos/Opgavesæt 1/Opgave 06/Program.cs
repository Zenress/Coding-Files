using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 4;

        //Udsagn://

            //1//False (Showed False)
            Console.WriteLine(a == b);

            //2// False (Showed False)
            Console.WriteLine(a > b);

            //3// True (Showed True)
            Console.WriteLine(a <= b);

            //4// True (Showed False)
            Console.WriteLine(a - b > 0);

            //5// True (Showed True)
            Console.WriteLine(a + b > 0);

            //6// False (Showed True)
            Console.WriteLine(a > 1 - b);
        }
    }
}
