using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car_classes;

namespace Car_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opg 19.1
            //Creating the 2 cars for the assignment
            Car bil1 = new Car("Dacia", "Logan", "Beige", 170000, false, false);
            Car bil2 = new Car("Toyota", "Yaris", "Rød", 89000, true, false);

            Car bil3 = new Car("Honda","Civic","White",199000,false, false);

            //Opg 19.3
            //Printing the information of the car
            Console.WriteLine(bil3);
            
        }
    }
}
