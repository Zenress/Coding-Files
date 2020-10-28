using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CarHandler;

namespace Opgave_17
{
    class Program
    {
        static void Main(string[] args)
        {
            /*//Opg 17.1
            //Creates the object Mustang, a car object
            Car Mustang = new Car("Ford", "Mustang", 1966, "Red");

            
            //Prints only the model information of the car
            Console.WriteLine(Mustang.ToString());
            //Prints the model information and color of the car
            Console.WriteLine(Mustang.GetInfo());
            
            //17.2
            //Changes car color
            Mustang.Color = "Blue";

            //Prints the newer model information
            Console.WriteLine(Mustang.GetInfo());

            //Prints a true or false statement
            Console.WriteLine(Mustang.StartCar());

            //Creating a list with a few cars
            List<Car> cars = new List<Car>();
            
            //Printing a message about the information on the cars
            Console.WriteLine("Information on the cars");
            //Actually printing all of the information
            foreach(Car c in cars)
            {
                Console.WriteLine(c.GetInfo());
            }*/

            //Making the menu
            Console.WriteLine("Hello and welcome to your car administrator");
            Console.WriteLine("You now have 2 options to choose from");
            Console.WriteLine("Do you wanna track another/New car(1) or do you wanna see all of the information on the current cars?(2)");

            //Making a int to store your selected number
            int selection = int.Parse(Console.ReadLine());

            //Making a list of already collected info
            List<Car> cars = new List<Car>();
            
            //Creating the cars for the list
            Car car1 = new Car("Ford", "Mustang", 1966, "Pink");
            //Just changing the color between the creation of cars
            Car car2 = new Car("Ford", "Mustang", 1966, "Yellow");
            //So it is easier to tell them appart
            Car car3 = new Car("Ford", "Mustang", 1966, "Magenta");
            //adding car 1
            cars.Add(car1);
            //Adding car 2
            cars.Add(car2);
            //Adding car 3
            cars.Add(car3);

            //If statements for making a new car and listing them
            if (selection == 1)
            {
                Console.Clear();
                Console.WriteLine("You have selected 1. Please enter the information in the following order");
                Console.WriteLine("1. Make, 2. Model, 3. Year, 4. Color");
                //Making the variables for containing the text and numbers to make the car item
                string make;
                string model;
                int year;
                string color;
                //Taking the user input of all these car items
                make = Console.ReadLine();
                model = Console.ReadLine();
                year = int.Parse(Console.ReadLine());
                color = Console.ReadLine();
                //Created the car object
                Car usercar = new Car(make, model, year, color);
                //Adds the car object to the list
                cars.Add(usercar);

                //Prints the information on the car object
                //Without .GetInfo(); it doesn't print the color
                Console.WriteLine(usercar.GetInfo());
            }
            if (selection == 2)
            {
                //Foreach loop for printing all of the cars
                foreach (Car c in cars)
                {
                    //Printing the cars
                    Console.WriteLine(c.GetInfo());
                }
            }
            else
            {
                //Making sure to quit the program if you don't select either 1 or 2
                System.Environment.Exit(0);
            }
        }

        

        
    }
}
