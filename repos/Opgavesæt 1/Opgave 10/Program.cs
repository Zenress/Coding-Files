using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_10
{
    class Program5
    {
        static void Main(string[] args)
        {
            //Opg 10.1 Kæledyrsopslagsværk
            /* 
             //Getting the usersinput to find out if it is in the switch statement
             Console.WriteLine("Please write one of the following animals: Undulat, Papegøje, Hund, Kat and Gris");
             string animalname = Console.ReadLine();
             string message = "";

             //Switch case for deciding if you wrote one of the animals that the program can recognize or if you didn't
             switch (animalname.ToLower())
             {
                 case "undulat":
                     message = "I made this message because otherwise the assignment would be useless";
                     break;
                 case "papegøje":
                     message = "Why am i here?";
                     break;
                 case "hund":
                     message = "EVOL";
                     break;
                 case "kat":
                     message = "Zetman";
                     break;
                 case "gris":
                     message = "DevilsLine";
                     break;
                 default:
                     animalname = "";
                     break;
             }
             //If statement for recognizing if you did or didn't write a correct animal
             if (animalname != "")
             {
                 Console.WriteLine($"You have written {animalname}\n{message}");
             }
             else
             {
                 Console.WriteLine("You have not written an animal that matches the list of animals");
             }
            */


            //10.2 Karakterbeskrivelse

            Console.WriteLine("Please write a number that corresponds with the grading system in Denmark");
            int grading = int.Parse(Console.ReadLine());

            switch (grading)
            {
                case -3:
                    Console.WriteLine("For den ringe præstation. Karakteren -3 gives for den helt uacceptable præstation.");
                    break;
                case 00:
                    Console.WriteLine("For den utilstrækkelige præstation. Karakteren 00 gives for den utilstrækkelige præstation, der ikke demonstrerer en acceptabel grad af opfyldelse af fagets/fagelementets mål.");
                   break;
                case 02:
                    Console.WriteLine("For den tilstrækkelige præstation. Karakteren 02 gives for den tilstrækkelige præstation, der demonstrerer den minimalt acceptable grad af opfyldelse af fagets/fagelementets mål.");
                    break;
                case 4:
                    Console.WriteLine("For den jævne præstation. Karakteren 4 gives for den jævne præstation, der demonstrerer en mindre grad af opfyldelse af fagets/fagelementets mål, med adskillige væsentlige mangler.");
                    break;
                case 7:
                    Console.WriteLine("For den gode præstation. Karakteren 7 gives for den gode præstation, der demonstrerer opfyldelse af fagets/fagelementets mål, med en del mangler.");
                    break;
                case 10:
                    Console.WriteLine("For den fortrinlige præstation. Karakteren 10 gives for den fortrinlige præstation, der demonstrerer omfattende opfyldelse af fagets/fagelementets mål, med nogle mindre væsentlige mangler.");
                    break;
                case 12:
                    Console.WriteLine("For den fremragende præstation. Karakteren 12 gives for den fremragende præstation, der demonstrerer udtømmende opfyldelse af fagets/fagelementets mål, med ingen eller få uvæsentlige mangler.");
                    break;
                default:
                    Console.WriteLine("You did not write a number that corresponds with the grading system");
                    break;
            }
            
        }
    }
}
