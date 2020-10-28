using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_classes
{
    class Car
    {
        public string Make;
        public string Model;
        public string Color;
        public double Price;
        public bool IsSold;
        public bool IsOnSale;
        //Opg 19.1 / 19.2 / Opg 19.3
        //Creating public fields that can be used to describe the car
        public Car(string Make, string Model, string Color, double Price, bool IsSold, bool IsOnSale)
        {
            IsOnSale = false;
            IsSold = false;
        }
        public void PutOnSale(string Make, string Model, string Color, double Price, bool IsSold, bool IsOnSale)
        {
            IsOnSale = true;
            Price = Price * 0.90;
        }
        public void PrintInfo(string Make, string Model, string Color, double Price, bool IsSold, bool IsOnSale)
        {
             if (IsSold == false)
             {
                   Console.WriteLine("The Car is a "+Make+" "+Model+" In the color "+Color+". The price is "+Price+" Dkk");
             }
             else
             {
                   Console.WriteLine("The car is sold!. "+"The Car is a " + Make + " " + Model + " In the color " + Color + ". The price is " + Price + " Dkk");
             }
        }
    }
}
