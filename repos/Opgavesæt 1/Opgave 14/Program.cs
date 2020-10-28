using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opg 14 Lists

            //Opg 14.1
            //Making a list with the name Ages and adding numbers to the list
            List<int> ages = new List<int>();
            //Adding numbers to the list Ages
            ages.Add(5);
            ages.Add(17);
            ages.Add(20);
            ages.Add(40);
            ages.Add(51);

            //Making a list with the name Names and adding strings to the lsit
            List<string> names = new List<string>();
            //Adding the strings to the names list
            names.Add("Jens");
            names.Add("Karl");
            names.Add("Johannes");
            names.Add("Anton");
            names.Add("Nicklas");

            //Opg 14.2
            //Making a list with the name Percentages and adding percantages to it
            List<double> percentages = new List<double>();
            //Adding the percantages to the percantages list
            percentages.Add(0.75);
            percentages.Add(0.23);
            percentages.Add(0.86);
            percentages.Add(0.17);

            //Making a list with the name areMarried and adding true or false to it
            List<bool> areMarried = new List<bool>();
            //Adding the true or false statements to the areMarried list
            areMarried.Add(true);
            areMarried.Add(false);
            areMarried.Add(false);
            areMarried.Add(true);
            areMarried.Add(true);

            //Opg 14.3
            //Printing the lists from opg 14.1
            //For loop for printing all of the ages from the list ages
            /*for (int i = 0; i < ages.Count; i++)
            {
                Console.WriteLine(ages[i]);
            }

            //For loop for printing all of the names from the list names
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }

            //Opg 14.3.5
            //Printing the lists from opg 14.2
            //Foreach loop for printing all of the percantages from the percantages list
            foreach (double value in percentages)
            {
                Console.WriteLine(value);
            }

            //Foreach loop for pritning all of the areMarried statements from the areMarried list
            foreach (bool value in areMarried)
            {
                Console.WriteLine(value);
            }*/


            //Opg 14.4
            //Using Insert() To insert a string on the list we create in this assignment
            //Creating a list with the classnames
            /*List<string> classnames = new List<string>()
            {
                "Hans", "Kristian", "Jens", "Karsten", "ib"
            };

            //Making a function with a for loop that prints the classnames
            void theirnames()
            {
                for (int i = 0; i < classnames.Count; i++)
                {
                    Console.WriteLine(classnames[i]);
                }
            }

            //Calling the function that prints all of the classnames
            theirnames();

            //inserting the name Anders at the 4th place in the list
            classnames.Insert(3,"Anders");

            //Inserting the name Lars at the 3rd place in the list
            classnames.Insert(2,"Lars");

            //Calling the function that prints all of the classnames
            //My guess is that Anders is gonna be 4th place, and Lars at 3rd place
            //Lars was right, but Anders was at 5th place.
            theirnames();*/


            //Opg 14.5
            //Making a list with ages and afterwards using 2 different methods to remove some of the items
            List<int> classages = new List<int>()
            {
                13,14,13,15,13,14,14,15
            };

            //function with a For loop for printing all of the classages
            void forloop()
            {
                for (int i = 0; i < classages.Count; i++)
                {
                    Console.WriteLine(classages[i]);
                }
            }

            //Calling the for loop to print all of the classages
            forloop();

            //Removing the first number 13 and the first number 15 from the list using the Remove() method
            classages.Remove(13);
            classages.Remove(15);

            //Writeline for making space between the printouts
            Console.WriteLine();

            //Calling the for loop again to print all of the classages after the changes
            forloop();

            //Removing the number at space number 3. My guess is that number 14 that is in space 4 will be removed
            classages.RemoveAt(3);

            //Writeline for making space between the printouts
            Console.WriteLine();

            //Calling the for loop again to print all of the classages after the changes
            forloop();
            //Conclusion i was right.
        }
    }
}
