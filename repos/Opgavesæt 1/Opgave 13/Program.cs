using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opg 13. Arrays


            //Opg 13.1
            /*int[ ] ages = new int[]
            {
                25,28,15,35,14
            };

            for (int i = 0; i < ages.Length; i++)
            {
                Console.WriteLine(ages[i]);
            }
*/

            //Opg 13.2
            //Making a Array with the names of classmates
            /*string[] names = new string[4] { "Hans", "Anton", "Betinna", "Daniel"  };
            
            //Function for calling for loop so i don't have to write it all 2 times
            void classnames()
            {
                //For loop for printing the names of all the classmates
                for (int i = 0; i < names.Length; i++)
                {
                    //Printing all of the strings in the array
                    Console.WriteLine(names[i]);
                }
            }

            //Calling the function mentioned above
            classnames();

            //Writeline for making spacing between each print
            Console.WriteLine();

            //Printing Daniels name with the word Kong in front
            Console.WriteLine("Kong " + names[3]);

            //Writeline for making spacing between each print
            Console.WriteLine();

            //Calling the function for the for loop
            classnames();*/


            //Opg 13.3
            //Making an array to sort it
            //Array with numbers used in this assignment
            /*int[] numbers = new int[]
            {
                7,79,95,73,78,18,76,80,60,21
            };

            //Function with the for loop for printing all of the numbers in the array above
            void forfunction()
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            //Calling the function before sorting the numbers to print the output of the numbers in the already assigned index
            forfunction();            

            //Sorting the array
            Array.Sort(numbers);

            //Writeline for making spacing between each print
            Console.WriteLine();

            //Calling the function after having sorted the numbers
            forfunction();

            //Trying the reverse array method. 
            Array.Reverse(numbers);

            //Writeline for making spacing between each print
            Console.WriteLine();

            //Calling the function but now with the reverse array method
            forfunction();
            */

            //Opgave 13.4
            //Making an array for adding +5 to every number
            int[] addition = new int[]
            {
                0,10,20,30,40,50,60,70,80,90
            };

            for (int i = 0; i < addition.Length; i++)
            {
                addition[i] = addition[i] + 5;
                Console.WriteLine(addition[i]);
            }
        }
    }
}
