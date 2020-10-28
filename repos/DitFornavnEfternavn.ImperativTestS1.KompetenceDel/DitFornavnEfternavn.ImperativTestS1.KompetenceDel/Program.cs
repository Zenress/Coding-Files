using System;
using System.Collections.Generic;

namespace DitFornavnEfternavn.ImperativTestS1.KompetenceDel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Making 2 lists that will hold the product name and a list that holds the price
            List<string> vare = new List<string>();
            List<int> pris = new List<int>();
            //Making a while loop that runs the program until you tell it to close
            while (true)
            {
                Console.Clear();
                //Printing out the menu
                Console.WriteLine("Her er en Menu hvor du kan vælge 3 forskellige ting");
                Console.WriteLine("a.   Indtast varer \nb.  Udregn total \nc.   Afslut");
                //Taking the user input and seeing if it matches one of the options
                char valgt = char.Parse(Console.ReadLine());                
                switch (valgt)
                {
                    //If you chose to type in a product and price
                    case 'a':
                        Console.WriteLine("Du har valgt Indtast. Du kan nu indtaste navnet på en varer og dens pris");                                                
                        bool afslutValgt = false;

                        //Runs the adding process in a loop until you tell it to stop
                        while (afslutValgt == false)
                        {
                            //Adds the product and the price to their respective lists
                            vare.Add(Console.ReadLine());
                            pris.Add(int.Parse(Console.ReadLine()));
                                Console.WriteLine("For at fortsætte med at tilføje varer så skriv a");
                                Console.WriteLine("For at gå tilbage til hovedmenuen skriv b");                            
                                string afslut = Console.ReadLine();

                            //Checks what option of the the you chose
                                if (afslut == "b")
                                {
                                    afslutValgt = true;
                                    break;
                                }
                                else if (afslut == "a")
                                {
                                    
                                }
                                else
                                {
                                    Console.WriteLine("Venligst skriv en af de 2 muligheder");
                                }
                        }                                       
                        break;
                    //If you chose Calculate total
                    case 'b':
                        //Prints the product and the price of each item in the list
                        for (int i = 0; i < vare.Count; i++)
                        {                            
                            Console.WriteLine("Vare: "+vare[i]+"\nPris: "+pris[i]);                            
                        }
                        int sum = 0;
                        //Adds the prises of the products together
                        for (int i = 0; i < pris.Count; i++)
                        {
                            
                            sum = sum + pris[i];
                        }
                        //Prints the sum of all the products
                        Console.WriteLine("Summen af varerne er: "+sum);

                        //Option to leave the b menu
                        Console.WriteLine("For at gå tilbage til hovedmenuen skriv b");
                        string afslut2 = Console.ReadLine();
                        if (afslut2 == "b")
                        {
                            afslutValgt = true;
                            break;
                        }
                        break;
                    //To close the program
                    case 'c':
                        Console.WriteLine("Farvel og tak");
                        System.Environment.Exit(0);
                        break;
                    //If you chose an option that doesn't exist
                    default:
                        Console.WriteLine("Du har indtastet en mulighed som ikke findes\n");
                        Console.ReadKey();
                        break;
                }
                
            }
        }
    }
}
