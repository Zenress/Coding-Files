using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_016
{
    class Program
    {
        //Method for printing a string that says hello
        private static void SayHello(string name)
        {
            //Printing the hello message along with the name that is specified when called upon
            Console.WriteLine("Hello "+name);
        }

        //Method for printing a string that says goodbye
        private static void SayGoodbye(string name)
        {
            //Printing the goodbye message along with the name that is specified when called upon
            Console.WriteLine("Goodbye "+name);
        }

        //Method for doubling a number
        private static int DoubleUp(int number)
        {
            //Assigning the calculation of DoubleUp to the number
            number = number * 2;
            //Printing the number
            Console.WriteLine(number);
            return number;
        }

        //Method for adding 2 numbers together
        private static int Addition(int a,int b)
        {
            //Printing the assigned sum of 2 numbers
            Console.WriteLine(a+b);
            return a + b;
        }

        //Method for finding the greatest of 2 numbers
        private static void FindGreatestNumber(int a, int b)
        {
            //Checks if a is bigger than b
            if (a > b)
            {
                //Writing out the result
                Console.WriteLine(a+" Is the greatest number");
            }
            else
            {
                //Writing out the result
                Console.WriteLine(b+" Is the greatest number");
            }
        }

        private static void StringArray( string[] yeet )
        {
            //For loop for printing every item in the string array
            for (int i = 0; i < yeet.Length; i++)
            {
                //Printing every item in the string array
                Console.WriteLine(yeet[i]);
            }            
        }

        static void Main(string[] args)
        {
            //Printing out the different methods
            SayHello("Yoink");
            SayGoodbye("Yeet");
            DoubleUp(10);
            Addition(5,5);
            FindGreatestNumber(10,15);
            StringArray(new string[]{"Hello","Hello"});
        }

        
    }
}
