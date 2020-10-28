using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FornavnEfternavn
{
    class Program
    {
        static void Main(string[] args)
        {
            //Below is the creation of the arrays used
            string[] myStringArray = new string[5]{ "Hello world", "yoink", "yeetus", "Hello there", "General Kenobi" };
            int[] myIntArray = new int[3] {1,2,3};
            double[] myDoubleArray = new double[3] {5,6,7};
            string input = "Type a number";
                       
            //Below is the calls for all of the methods
            PrintArray(myStringArray);
            PrintArray(myIntArray);
            PrintArray(myIntArray, 'c');
            CalcualteSum(myIntArray);
            CalculateSum(myDoubleArray);
            CalculateAvg(myIntArray);
            CalculateAvg(myDoubleArray);
            ReadUntilInt(input);
            ReadUntilDouble(input);                        
        }
        
        //Prints the string array
        private static void PrintArray(string[] myArray)
        {
            //For loop for doing iterations to print the array with its index
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
        }

        //Prints the int array
        private static void PrintArray(int[] myIntArray)
        {
            //For loop for doing iterations to print the array with its index
            for (int i = 0; i < myIntArray.Length; i++)
            {
                Console.WriteLine(myIntArray[i]);
            }
        }

        //Prints the array along with a char to go with it
        private static void PrintArray(int[] myIntArray, char character)
        {
            //For loop for doing iterations to print the array with its index
            for (int i = 0; i < myIntArray.Length; i++)
            {
                Console.Write(myIntArray[i]+""+character+" ");
            }
        }

        //Calculates the sum of the int array
        private static int CalcualteSum(int[] myIntArray)
        {
            //Using the return function to return the int value it needs
            Console.WriteLine("\n"+myIntArray.Sum());
            return myIntArray.Sum();              
        }

        //Calculates the sum of the double array
        private static double CalculateSum(double[] myDoubleArray)
        {
            //Using the return function to return the int value it needs
            Console.WriteLine(myDoubleArray.Sum()); 
            return myDoubleArray.Sum();
        }

        //Calculates the average of the int array
        private static int CalculateAvg(int[] myIntArray)
        {
            //Prints the average of the int array
            Console.WriteLine((int)myIntArray.Average());
            return (int)myIntArray.Average();
        }

        //Calculates the average of the double array
        private static double CalculateAvg(double[] myDoubleArray)
        {
            //Prints the average of the double array
            Console.WriteLine(myDoubleArray.Average());
            return myDoubleArray.Average();
        }

        //Asks the user for an input until they decide that they have to type a number
        private static int ReadUntilInt(string input)
        {
            //Declaring the variables
            string userInput = null;
            int number;
            //While loop that runs for as long as the user doesn't type a number
            while (int.TryParse(userInput,out number) == false)
            {
                Console.WriteLine(input);
                userInput = Console.ReadLine();
            }            
            return number;
        }

        //Asks the user for an input until they decide that they have to type a number
        private static double ReadUntilDouble(string input)
        {
            //Declaring the variables
            string userInput = null;
            double number;
            //While loop that runs for as long as the user doesn't type a number
            while (double.TryParse(userInput, out number) == false)
            {
                Console.WriteLine(input);
                userInput = Console.ReadLine();
            }
            return number;
        }
    }
}
