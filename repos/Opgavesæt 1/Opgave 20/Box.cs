using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_20
{
    public class Box
    {
        int Height;
        int Length;
        int Width;
        //Making required fields and specifying their standard values
        public Box(int height, int length, int width)
        {
            Height = height;
            Length = length;
            Width = width;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"The box has the following measurements: \n Height: {Height}\n Length: {Length} \n Width: {Width}");
        }
    }
}
