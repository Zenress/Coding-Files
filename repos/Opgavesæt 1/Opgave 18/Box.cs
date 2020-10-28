using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_18
{
    public class Box
    {
        int Width;
        int Height;
        int Length;
        //Making required fields and specifying their standard values
        public Box(int width, int height, int length)
        {
            Width = width;
            Height = height;
            Length = length;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"The box has the following measurements: \n Height: {Height}\n Length: {Length} \n Width: {Width}");
        }
    }
}
