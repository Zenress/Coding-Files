using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Opgavesæt
{
    class Program
    {
        class Person
        {
            //Opg 12-13 solution
            public byte Height;
            public double Weight;
            public int Age;
            public long Income;
            public string HairColor;

            public Person(byte height, double weight, int age, long income, string haircolor)
            {
                Height = height;
                Weight = weight;
                Age = age;
                Income = income;
                HairColor = haircolor;
            }

            void CheckHeight(int userInput, int targetHeight)
            {
                if (targetHeight > userInput)
                {
                    Console.WriteLine("You really are short aren't you?");
                }
                else if (userInput > targetHeight)
                {
                    Console.WriteLine("Damn you're tall");
                }
            }

            void CheckWeight(int userInput, int targetWeight)
            {
                if (targetWeight > userInput)
                {
                    Console.WriteLine("You really aren't that fat are you?");
                }
                else if (userInput > targetWeight)
                {
                    Console.WriteLine("Damn you're fat");
                }
            }

            void CheckAge(int userInput, int targetAge)
            {
                if (targetAge > userInput)
                {
                    Console.WriteLine("You really are young aren't you?");
                }
                else if (userInput > targetAge)
                {
                    Console.WriteLine("Damn you're old");
                }
            }

            void IncomeHigh(int userInput, int highIncome)
            {
                if (highIncome > userInput)
                {
                    Console.WriteLine("Broke ass");
                }
                else if (userInput > highIncome)
                {
                    Console.WriteLine("Rich damn");
                }
            }

            void IncomeLow(int userInput, int lowIncome)
            {
                if (lowIncome > userInput)
                {
                    Console.WriteLine("Rich damn");
                }
                else if (userInput > lowIncome)
                {
                    Console.WriteLine("Broke ass");
                }
            }

            void HairColorCheck(string userInput)
            {
                userInput.ToLower();
                switch (userInput)
                {
                    case "white":
                        Console.WriteLine("Starting to look old aren't we?");
                        break;
                    case "black":
                        Console.WriteLine("Goth person in the house");
                        break;
                    case "gray":
                        Console.WriteLine("A little old aren't we?");
                        break;
                    case "blue":
                        Console.WriteLine("Going out of the social norm huh?");
                        break;
                    case "red":
                        Console.WriteLine("You have no soul");
                        break;
                    case "yellow":
                        Console.WriteLine("Blondie lol");
                        break;
                    default:
                        break;
                }
            }
            //Opg 12-13 solution over
        }

        static void Main(string[] args)
        {
            //OPG 1 Solution
            //Ints for the input of the user and the number that is used for the assignment
            /*int input = int.Parse(Console.ReadLine());
            int number = 1;
            //For loop that runs as many times as the input states it should
            for (int i = 0; i < input; i++)
            {
                //Writes the number and then does the calculations for the next time the loop runs
                Console.WriteLine(number);
                number *= 2;
            }*/
            //Opg 1 Solution over


            //Opg 2 Solution
            //Ints for the input of the user and the number that is used for the assignment
            /*int inputOpg2 = int.Parse(Console.ReadLine());
            int numberOpg2 = 1;
            //For loop that runs as many times as the input states it should
            for (int i = 0; i < inputOpg2; i++)
            {
                //Writes the number and then does the calculations for the next time the loop runs
                Console.WriteLine(numberOpg2);
                numberOpg2 *= 3;
            }*/
            //Opg 2 Solution over


            //Opg 3 Solution
            //List for containing the number sequence
            /*List<int> numbers = new List<int>();
            //Taking the users input for use in adding the numbers to the list
            double inputOpg3 = double.Parse(Console.ReadLine());
            //The ints that holds the 2 numbers
            int number1Opg3 = 1;
            int number2Opg3 = 2;
            //Adding the numbers to the list of numbers
            for (int i = 0; i < inputOpg3; i++)
            {
                numbers.Add(number1Opg3);
                numbers.Add(number2Opg3);
                //Making use of the +3 pattern in the sequence
                number1Opg3 += 3;
                number2Opg3 += 3;
            }
            //Printing the number sequence
            //The math is like this: If you type 10. Then it will make the sequence 20 values long.
            //Therefore we divide it by 2 so it only displays 10 numbers. This makes it work with 11 and 13 as well.
            for (int i = 0; i < numbers.Count/2; i++)
            {
                Console.WriteLine(numbers[i]);
            }*/
            //Opg 3 Solution over


            //Opg 4 Solution
            /*int inputOpg4 = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();
            for (int i = 0; i < inputOpg4; i++)
            {
                numbers.Add(i);
                if (numbers[i] % 4 == 0 || numbers[i] % 3 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }*/
            //Opg 4 Solution over


            //Opg 5 Solution
            /*bool IsPrime(int number)
            {
                //Checks the 3 smaller rules of prime numbers
                if (number <= 1) return false;
                if (number == 2) return true;
                if (number % 2 == 0) return false;

                //Takes the square route of the number
                var boundary = (int)Math.Floor(Math.Sqrt(number));

                //Checks if the number isn't prime
                for (int i = 3; i <= boundary; i++)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }                    
                }
                //If it is prime then return true
                return true;                    
            }

            //Takes the input of the user
            int number1 = int.Parse(Console.ReadLine());
            //Makes a list for containing every number below the user input
            List<int> numbers = new List<int>();
            //For loop for printing and adding the list items
            for (int i = 0; i < number1; i++)
            {
                numbers.Add(i);
                //If statement for printing all of the prime numbers
                if (IsPrime(numbers[i]) == true)
                {
                    Console.WriteLine(numbers[i]);
                }
            }*/
            //Opg 5 Solution over


            //Opg 6 Solution
            /*int number1 = 0;
            int number2 = 1;
            int number3 = 0;

            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number1+"\n"+number2);
            for (int i = 2; number3 < number; i++)
            {
                number3 = number1 + number2;
                if (number3 < number)
                {
                    Console.WriteLine(number3);
                }
                number1 = number2;
                number2 = number3;
            }*/
            //Opg 6 solution over


            //Opg 7 Solution
            /*void LameJoke()
            {
                //Random that gets a random number betweeb 0-10
                Random rand = new Random();
                int random = rand.Next(0, 11);
                //Switch case that prints a random joke according to the number the random has made
                switch (random)
                {
                    case 1:
                        Console.WriteLine("Where do you take someone who has been injured in a Peek-a-Boo accident? To the I.C.U.");
                        break;
                    case 2:
                        Console.WriteLine("What do you call the security outside of a Samsung Store? Guardians of the Galaxy.");
                        break;
                    case 3:
                        Console.WriteLine("What do we call a crying sister? A crisis.");
                        break;
                    case 4:
                        Console.WriteLine("I have a lot of good jokes about unemployed people... But none of them work.");
                        break;
                    case 5:
                        Console.WriteLine("Why was the stadium so cold? Because there were a lot of fans.");
                        break;
                    case 6:
                        Console.WriteLine("What should you do, if you get locked out of your house? Talk to the lock, because communication is key.");
                        break;
                    case 7:
                        Console.WriteLine("What do you call a bee that was born is the United States? A USB.");
                        break;
                    case 8:
                        Console.WriteLine("How do you help a router with digestion issues. Give it fiber!");
                        break;
                    case 9:
                        Console.WriteLine("What are the strongest days of the week? Saturday and Sunday the rest are week days.");
                        break;
                    case 10:
                        Console.WriteLine("What kind of music is a balloon scared of? Pop music.");
                        break;
                    default:
                        break;
                }
            }
            LameJoke();*/
            //Opg 7 Solution over


            //Opg 8 Solution
            /*void FactsOfLife()
            {
                //Random that gets a random number betweeb 0-10
                Random rand = new Random();
                int random = rand.Next(0, 11);
                //Switch case that prints a random joke according to the number the random has made
                switch (random)
                {
                    case 1:
                        Console.WriteLine("Banging your head against a wall for one hour burns 150 calories.");
                        break;
                    case 2:
                        Console.WriteLine("In Switzerland it is illegal to own just one guinea pig.");
                        break;
                    case 3:
                        Console.WriteLine("Pteronophobia is the fear of being tickled by feathers.");
                        break;
                    case 4:
                        Console.WriteLine("Snakes can help predict earthquakes.");
                        break;
                    case 5:
                        Console.WriteLine("The oldest “your mom” joke was discovered on a 3,500 year old Babylonian tablet.");
                        break;
                    case 6:
                        Console.WriteLine("29th May is officially “Put a Pillow on Your Fridge Day”");
                        break;
                    case 7:
                        Console.WriteLine("Cherophobia is an irrational fear of fun or happiness.");
                        break;
                    case 8:
                        Console.WriteLine("7% of American adults believe that chocolate milk comes from brown cows.");
                        break;
                    case 9:
                        Console.WriteLine("If you lift a kangaroo’s tail off the ground it can’t hop.");
                        break;
                    case 10:
                        Console.WriteLine("During your lifetime, you will produce enough saliva to fill two swimming pools.");
                        break;
                    default:
                        break;
                }
            }
            FactsOfLife();*/
            //Opg 8 Solution over


            //Opg 9 solution
            //Method for printing all of the min and max values of all the unsigned datatypes
            /*void smallestBiggest()
            {
                //Byte
                Console.WriteLine(byte.MaxValue+"-"+ byte.MinValue);                
                //Ushort
                Console.WriteLine(ushort.MaxValue + "-" + ushort.MinValue);                
                //Uint
                Console.WriteLine(uint.MaxValue + "-" + uint.MinValue);                
                //Ulong
                Console.WriteLine(ulong.MaxValue + "-" + ulong.MinValue);                              
            }
            //Calling the function
            smallestBiggest();*/
            //Opg 9 Solution over


            //Opg 10 Solution
            //Method for Array sorting and printing it
            /*void ArraySmall(int[] numbers)
            {
                Array.Sort(numbers);
                Console.WriteLine(numbers[0]);
            }
            //The array that is used for the Arraysmall function
            int[] number = new int[] {10,20,30,40,5,1};
            ArraySmall(number);*/
            //Opg 10 Solution over


            //Opg 11 Solution
            void recursiveFunction(int n)
            {
                n -= 1;
                Console.WriteLine(n);
                if (n == 0)
                {
                    return;
                }
                recursiveFunction(n);
            }
            int input = int.Parse(Console.ReadLine());
            recursiveFunction(input);
            //Opg 11 Solution over


            //Opg 15 solution
            Person Shano = new Person(186,85.3,18,3600,"gray");
            //Opg 15 solution over


            //Opg 17 solution
            Console.WriteLine("I completed the assignment of today");
            //Opg 17 solution over
        }
    }
}
