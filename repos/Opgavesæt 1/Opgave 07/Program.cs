using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_07
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opg 7.1
            /*//Message for user
            Console.Write("Enter the amount of money you wanna shop for: ");

            //Reading the users input and storing it
            double shoppingmoney = double.Parse(Console.ReadLine());

            //Creating a variable for discount
            double discount = 0;

            //If statemenet checking if the price is over 1000 and deciding if it should give 5% off
            if (shoppingmoney >= 1000)
            {
                discount = shoppingmoney * 0.05;
            }

            //Printing the discounted price
            Console.WriteLine("Your discoun is: "+discount);*/


            //Opg 7.2
            //Getting the users input for number1
            /*Console.WriteLine("Please write the first number");
            int number1 = int.Parse(Console.ReadLine());

            //Getting the users input for number2
            Console.WriteLine("Please write the second number");
            int number2 = int.Parse(Console.ReadLine());

            //If statement checking whether the two numbers are identical or not
            if (number1 == number2)
            {
                Console.WriteLine("These two numbers are identical");
            }
            else
            {
                Console.WriteLine("These two numbers are not identical");
            }*/


            //Opg 7.3
            /*//Getting the users input for number1
            Console.WriteLine("Please write the first number");
            int number1 = int.Parse(Console.ReadLine());

            //Getting the users input for number2
            Console.WriteLine("Please write the second number");
            int number2 = int.Parse(Console.ReadLine());

            //If statement checking whether the two numbers are identical or not
            if (number2 == 0)
            {
                Console.WriteLine("You cannot divide by the number 0");
            }
            else
            {
                Console.WriteLine("The results are: "+ number1 / number2);
            }*/


            /*//Opg 7.4
            //Int for containing the highest number
            int highestnumber;
            //Getting the users input for number1
            Console.WriteLine("Please write the first number");
            int number1 = int.Parse(Console.ReadLine());

            //Getting the users input for number2
            Console.WriteLine("Please write the second number");
            int number2 = int.Parse(Console.ReadLine());

            //If statement checking which of the 2 numbers are highest
            if (number1 < number2)
            {
                highestnumber = number2;
                Console.WriteLine("The highest number is: "+highestnumber);
            }
            else if (number2 < number1)
            {
                highestnumber = number1;
                Console.WriteLine("The highest number is: "+highestnumber);
            }
            else
            {
                Console.WriteLine("These two numbers are not identical");
            }*/


            /*//Opg 7.5
            //Printing a message for the user and taking the inputs and storing them
            Console.WriteLine("Input 2 numbers and i'll show them in rising order");
            //Taking the first number input
            Console.WriteLine("Input the first number");
            int number1 = int.Parse(Console.ReadLine());
            //Taking the second number input
            Console.WriteLine("Input the second number");
            int number2 = int.Parse(Console.ReadLine());

            //If statement for determining which number should go first in the order
            if (number1 > number2)
            {
                Console.WriteLine(number2);
                Console.WriteLine(number1);
            }
            else
            {
                Console.WriteLine(number1);
                Console.WriteLine(number2);
            }*/


            /*//Opg 7.6
            //Taking the users number and figuring out if the number is positive, negative or 0
            Console.WriteLine("Input a number and i will figure out whether the number is positive, negative or 0");
            int number = int.Parse(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("The number is positive");
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is negative");
            }
            else if (number == 0)
            {
                Console.WriteLine("The number is 0");
            }*/


            //Opg 7.7
            int weight;
            string express;

            //Consumer function
            void consumer ()
            {                                  
            //Making a description of the program to the user
            Console.WriteLine("This program will help you with the porto of mailing a letter");
            //Getting the weight of the letter and taking the input and putting it into an int
            Console.Write("Please enter the weight of the letter ");
            weight = int.Parse(Console.ReadLine());
            //Express or normal shipping?
            Console.WriteLine("Express or normal shipping? Express is 50% more expensive but 150% faster");
            express = Console.ReadLine();
            }

            //Calling the optimized methods
            consumer();
            price();

            //Price function 
             void price()
            {
                double packageprice;

                

            if (weight < 20)
                {        
                     packageprice = 5;
                    
                }
            else if (weight >= 20 && weight < 50)
                {
                    packageprice = 7;
                    
                }
            else if (weight >= 50 && weight < 100)
                {
                    packageprice = 10;
                    
                }
            else if (weight >= 100 && weight < 150)
                {
                    packageprice = 15;
                    
                }
            else if (weight >= 150 && weight < 200)
                {
                    packageprice = 20;
                    
                }
            else
                {
                    packageprice = 30;
                    
                }
            if (express == "express" || express == "Express")
                {
                    packageprice *= 1.5;
                }

                Console.WriteLine("The price is: "+packageprice);
            }


        }
    }
    
}
