using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opg 11.1 Print while loops
            /*
            //Number 1-10
            int number110 = 1;

            while (number110 < 11)
            {
                Console.WriteLine(number110);
                number110++;
            }

            //Spacing between numbers
            Console.WriteLine();

            //Number 10-1
            int number101 = 10;

            while (number101 > 0)
            {
                Console.WriteLine(number101);
                number101--;
            }

            //Spacing between numbers
            Console.WriteLine();

            //Equal numbers 1-20
            int equalnumber = 0;

            while (equalnumber <= 20)
            {
                Console.WriteLine(equalnumber);
                equalnumber += 2;
            }

            //Spacing between numbers
            Console.WriteLine();

            //Unequal numbers 1-20
            int unequalnumber = 1;

            while (unequalnumber <= 20)
            {
                Console.WriteLine(unequalnumber);
                unequalnumber += 2;
            }*/


            //Opg 11.2 Write a number and the program will write out a table of that number
            //Getting the users input and using that for the table
            /*Console.WriteLine("Write a number and i will write out the table of the number");
            int table = int.Parse(Console.ReadLine());

            int number = 0;
            
            //While loop printing the information of the table until it hits the end of that table
            while (number <= table * 10)
            {
                Console.WriteLine(number);
                number += table;
            }*/


            //Opg 11.3 Get the right input
            /*int Userinput = -1;
            int attempts = -1;
            while (Userinput <1 || Userinput >10)
            {
                Console.WriteLine("Write a number between 1-10");
                Userinput = int.Parse(Console.ReadLine());
                attempts++;
            }
            if (attempts > 0)
            {
                Console.WriteLine($"You did well. It took {+attempts} attempt(s).. Asshole");
            }
            else
            {
                Console.WriteLine("You did well.");
            }
            */

        }
    }
}
