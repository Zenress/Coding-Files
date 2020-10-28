using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_12
{
    class Program
    {
        //Opg 12.4.1 Created a random object to generate random numbers for me
        static Random rand = new Random();

        //Main object
        static void Main(string[] args)
        {
            //Opg 12.1 For loops
            //Counting from 1-10
            for (int i = 0; i < 11; i++)
            {
                //Printing the value of i to the screen
                Console.WriteLine(i);
            }

            //Spacing between outputs
            Console.WriteLine();

            //Counting from 10-1
            for (int i = 10; i > 0; i--)
            {
                //Printing the value of i to the screen
                Console.WriteLine(i);
            }

            //Spacing between outputs
            Console.WriteLine();

            //Counting all equal numbers
            for (int i = 0; i <= 20; i += 2)
            {
                //Printing the value of i to the screen
                Console.WriteLine(i);
            }

            //Spacing between outputs
            Console.WriteLine();

            //Counting all unequal numbers
            for (int i = 1; i <= 20; i += 2)
            {
                //Printing the value of i to the screen
                Console.WriteLine(i);
            }


            //Opg 12.2 table for loop
            Console.WriteLine("Write a number and i will print a table of it");
            //Taking the users input and assigning it to the table int
            int table = int.Parse(Console.ReadLine());

            //For loop for printing the table of the given number you typed above
            for (int i = table; i < table * 11; i += table)
            {
                //Printing the value of i to the screen
                Console.WriteLine(i);
            }


            //Opg 12.3 All tables
            //Function for printing a full table list
            void table1()
            {
                //For loop for running the nested loop that counts toward the 10 rows of code
                for (int i = 1; i < 11; i++)
                {
                    //For loop counting towards the 10 rows of columns, making sure that it follows a table
                    for (int j = 1; j < 11; j++)
                    {
                        //Making the table
                        Console.Write((j * i).ToString().PadLeft(4));
                    }
                    //Making a new line to ensure there is space
                    Console.WriteLine();
                }
            }

            //Calling the function made up above, was not part of the assignment but did it anyway
            table1();


            //Opg 12.4 Int for counting the number that the dice thew
            int randomnumber;

            //For loop that throws a dice 10 times and prints the numbers it got
            for (int i = 0; i < 11; i++)
            {
                //Int for throwing the dice
                int random = rand.Next(1, 7);
                //Writing the number to the screen
                Console.WriteLine(random);
            }

            //For spacing inbetween numbers
            Console.WriteLine();

            //For loop that throws a dice until it hits the number 6
            for (int i = 0; i < 1 ;)
            {
                //Int for throwing the dice
                int random = rand.Next(1, 7);
                //Writing the number to the screen
                Console.WriteLine(random);
                //Making the random number created by the int and making that the randomnumber int
                randomnumber = random;

                //If statement for shutting down the for loop when it reaches the 6 on a dice
                if (randomnumber == 6)
                {
                    i++;
                }
            }

            //For spacing inbetween numbers
            Console.WriteLine();

            //For loop made for fun trying to see what would happen if you used a 20 sided dice
            for (int i = 0; i < 1;)
            {
                //Int for throwing the dice
                int random = rand.Next(1, 21);
                //Writing the number to the screen
                Console.WriteLine(random);
                //Making the random number created by the int and making that the randomnumber int
                randomnumber = random;

                //If statement for shutting down the for loop when it reaches the 20 on a dice
                if (randomnumber == 20)
                {
                    i++;
                }
            }

        }
    }
}
