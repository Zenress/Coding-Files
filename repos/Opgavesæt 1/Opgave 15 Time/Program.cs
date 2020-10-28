using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_15_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opg 15-15.4
            //Making a boolean variable for telling the loop to run
            bool open = true;
            //Making an int to tell which option has been chosen
            int optionchosen;

            //Making a function so i don't have to repeat the menu
            void menu()
            {
                //For space
                Console.WriteLine();
                //Displaying the menu
                Console.WriteLine("The following is a list of things this program can do");
                Console.WriteLine();
                Console.WriteLine("1: Display the time right now");
                Console.WriteLine();
                Console.WriteLine("2: Display time until christmas");
                Console.WriteLine();
                Console.WriteLine("3. Time until your birthday");
                Console.WriteLine();
                Console.WriteLine("4: Time till selected date");
                Console.WriteLine();
            }

            //While loop for the whole menu
            while (open)
            {
                //Calling the menu
                menu();

                //Taking the users input
                optionchosen = int.Parse(Console.ReadLine());

                //If statement for seing if the user wrote a number from the list
                if (optionchosen <= 4)
                {
                    //Making a switch case to display the correct answer
                    switch (optionchosen)
                    {
                        //Checking what the current time and date is
                        case 1:
                            //For Space
                            Console.WriteLine();

                            //Changing the background color of the line
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Magenta;

                            //Writing out today's time and date
                            Console.WriteLine("Today: {0}", DateTime.Now, DateTime.UtcNow);
                            
                            break;
                        //Checking the time between now and christmas
                        case 2:
                            //DateTime variable for Christmas
                            DateTime christmas = Convert.ToDateTime("24/12/2020");
                            //DateTime variable for getting the current day
                            DateTime todaydate = DateTime.Now;
                            //Calculatign the days left
                            int numberofdays = (int)(christmas - todaydate).TotalDays;

                            //For spacing
                            Console.WriteLine();

                            //Changing the background color of the line
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Magenta;

                            //Writing out the number of days between now and christmas
                            Console.WriteLine("Number of days till christmass: "+numberofdays);
                            break;
                        //Checking the time until the users birthday
                        case 3:
                            //Making a string to contain the usersbirthday
                            DateTime userbirthday;

                            //For space
                            Console.WriteLine();

                            //Taking the birthday input of the user
                            Console.WriteLine("Please input your birthday: day/month/year");
                            //For space
                            Console.WriteLine();

                            //Changing the background color of the line
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Magenta;

                            //Making the userinput the date and time to calculate
                            userbirthday = Convert.ToDateTime(Console.ReadLine());
                            //Calculating the time between the users birthday and today
                            numberofdays = (int)(userbirthday - DateTime.Now).TotalDays;
                            Console.WriteLine("Days until your birthday: "+numberofdays);
                            break;
                        //Checking the time until the specified date
                        case 4:
                            DateTime currentday = DateTime.Now;

                            //For spacing
                            Console.WriteLine();

                            //Asking the user for an input
                            Console.WriteLine("Which date would you like for me to calculate the time for? day/month/year");

                            //Taking the specified date the user has entered
                            DateTime specifieddate = Convert.ToDateTime(Console.ReadLine());

                            //calculating the day
                            numberofdays = (int)(specifieddate-currentday).TotalDays;

                            //Changing the background color of the line
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Magenta;

                            Console.WriteLine("The time till the date you entered is: "+numberofdays);
                            break;

                        default:
                            break;
                    }                        
                }
                else
                {
                    Console.WriteLine("You have written something that isn't specified on the list. Please restart the program and follow the instructions :)");
                    open = false;
                    break;
                }
                //Changing the background color of the line back
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
