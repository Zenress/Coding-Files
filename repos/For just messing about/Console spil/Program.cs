using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_spil
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rule presentation
            Console.WriteLine("Hello and welcome to my game\n");
            Console.WriteLine("I will select a number between 1-20 and you have to guess it in 6 or less tries\n");



            // End of rule presentation

            //Number guessing and making you guess it
            Random number = new Random();

            
            int randomnumber = number.Next(1, 21);
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Write your guess");
                int guess = int.Parse(Console.ReadLine());
                if (randomnumber == guess)
                {
                    Console.WriteLine("You guessed right.");                    
                    break;
                }
                else
                {
                    Console.WriteLine($"You guess wrong. You have {5-i} guesses left");
                    if (randomnumber > guess)
                    {
                        Console.WriteLine("Your guess was too low");
                    }
                    else
                    {
                        Console.WriteLine("Your guess was too high");
                    }
                }                
            }
            Console.WriteLine("The number was "+randomnumber);


            // End of number guessing

            //Give the player 6 guesses / Telling you if your guess was wrong



            // End of player guessing


        }
    }
}
