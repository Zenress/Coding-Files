using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Aritmetik
{
    class Program
    {
        static void Main(string[] args)
        {
            /*//Opg 5.1 Calculator that can only calculate addition
            Console.WriteLine("Welcome to THE calculator");
            Console.WriteLine("Version 1.01");

            //Describing the calculator to the user
            Console.WriteLine("I am a simple yet amazing calculator, i can add 2 numbers together\n");

            //Taking the users first input
            Console.Write("Enter the first number: ");
            uint number1 = uint.Parse(Console.ReadLine());

            //Taking the users second input
            Console.Write("Enter the second number: ");
            uint number2 = uint.Parse(Console.ReadLine());

            //Adding the numbers together
            Console.WriteLine("The result of the addition is = "+(number1+number2));*/

            //Making the user interface more pretty
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WindowHeight = 50;
            Console.WindowWidth = 213;

            //Opg 5.2 Calculator that can only calculate addition
            Console.WriteLine("Welcome to THE calculator");
            Console.WriteLine("Version 2.15");

            //Describing the calculator to the user
            Console.WriteLine("I am a simple yet amazing calculator, i can add, subtract, multiply, divide and take the remainder of numbers together\n");

            //Taking the users first input
            Console.Write("Enter the first number: ");
            double number1 = double.Parse(Console.ReadLine());

            //Taking the users second input
            Console.Write("Enter your method of calculating: ");
            char calculate = char.Parse(Console.ReadLine());

            //Taking the users third input input
            Console.Write("Enter the second number: ");
            double number2 = double.Parse(Console.ReadLine());

            //Adding the numbers together, using if statements and else if to make it more optimized
            if (calculate == '+')
            {
                Console.WriteLine(number1 + number2);
            }
            else if (calculate == '-')
            {
                Console.WriteLine(number1 - number2);
            }
            else if (calculate == '*')
            {
                Console.WriteLine(number1 * number2);
            }
            else if (calculate == '/')
            {
                Console.WriteLine(number1 / number2);
            }
            else if (calculate == '%')
            {
                Console.WriteLine(number1 % number2);
            }
            //Making the program quit if you type a invalid calculation method
            else
            {
                Console.WriteLine("You have entered a calculation method that does not coencide with any methods i can use. \nThe program will terminate in 5 seconds\n Thank you...");

                Thread.Sleep(5000);

                System.Environment.Exit(5);
             
                       
            }
        }
    }
}
