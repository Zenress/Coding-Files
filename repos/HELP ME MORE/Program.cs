using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HELP_ME_MORE
{
    class Program
    {
        static void Main(string[] args)
        {
            //Navn//
            string navn;

            //Alder//
            string alder; //Should be byte//

            //Yndlingsfarve//
            string yfarve;

            //Højde//
            string højde; //Should be byte//
            string højdecm;

            //Køn//
            string køn;

            //Livsstatus//
            string alive; //Should be boolean//

            //Questions, input collectors and screen clearers, making it more Clean and user friendly//
            //Question for name and reading input//
            Console.WriteLine("Hvad er dit navn?");
                navn = Console.ReadLine();
                    Console.Clear();

            //Question for age and reading input//
            Console.WriteLine("Hvad er din alder?");
                alder = Console.ReadLine();
                    Console.Clear();

            //Question for favorite color and reading input//
            Console.WriteLine("Hvad er din yndlingsfarve?");
                yfarve = Console.ReadLine();
                    Console.Clear();

            //Question for height and reading input//
            Console.WriteLine("Hvad er din højde?");
                højde = Console.ReadLine();
                    Console.Clear();

            //Question for height measurement and reading input//
            Console.WriteLine("Hvad er måleenheden for din højde?");
                højdecm = Console.ReadLine();
                    Console.Clear();

            //Question for gender and reading input//
            Console.WriteLine("Hvad er dit køn?");
                køn = Console.ReadLine();
                    Console.Clear();

            //Question for are you alive and reading input//
            Console.WriteLine("Er du i live?");
                alive = Console.ReadLine();
                    Console.Clear();

            //If statements for rewarding the user for answering correctly//
            //If else statement for navn//
            if (navn == "Shano")
            {
                Console.WriteLine(navn + " | That is correct");
            }
            else
            {
                Console.WriteLine(navn + " | That is wrong");
            }

            //If else statement for alder//
            if (alder == "18")
            {
                Console.WriteLine(alder + " | That is correct");
            }
            else
            {
                Console.WriteLine(alder + " | That is wrong");
            }

            //If else statement for yfarve//
            if (yfarve == "unik blå")
            {
                Console.WriteLine(yfarve + " | That is correct");
            }
            else
            {
                Console.WriteLine(yfarve + " | That is wrong");
            }

            //If else statement for højde and højdecm//
            if (højde + højdecm == "186cm")
            {
                Console.WriteLine(højde + højdecm + " | That is correct");
            }
            else
            {
                Console.WriteLine(højde + højdecm + " | That is wrong");
            }

            //If else statement for køn//
            if (køn == "han")
            {
                Console.WriteLine(køn + " | That is correct");
            }
            else
            {
                Console.WriteLine(køn + " | That is wrong");
            }

            //If else statement for alive//
            if (alive == "ja")
            {
                Console.WriteLine(alive + " | That is correct");
            }
            else
            {
                Console.WriteLine(alive + " | That is wrong");
            }
        }
    }
}
