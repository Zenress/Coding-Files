using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Test_for_codewars
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Test1 = new int[] { 1, 1, 1, 1 };
            TestMethod(Test1);
        }

        public static void TestMethod(int[] BinaryArray)
        {            
            int i = 0;
            string binaryNumberString = "";
            foreach (var ch in BinaryArray)
            {
                binaryNumberString += BinaryArray[i].ToString();
                i++;
            }
            int result = Convert.ToInt32(binaryNumberString,2);
            Console.WriteLine(result);
        }
              
    }
}
