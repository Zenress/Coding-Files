using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Opgave_20;


namespace Opgave_20
{
    class Program
    {
        static void Main(string[] args)
        {
            /*using (StreamReader sr = new StreamReader("Values.txt"))
            {
                while (!(sr.EndOfStream == true))
                {
                    //Opg 20.1
                    //Creating the variables to be used. Counter for telling the user which number corresponds to which place
                    //And Sum to calculate the numbers added together
                    //And average for calculating the average of all of the numbers
                    int counter = 0;
                    int sum = 0;
                    int average;
                    //Array for holding the numbers
                    string[] line = new string[10]; 
                    //For loop for creating all of the array values
                    for (int i = 0; i < 10; i++)
                    {
                        //Taking the output of the Streamreader and writing that to the index
                       line[i] = sr.ReadLine();
                        //Adding plus 1 to make sure the counter is at 10
                       counter = i+1;
                        //Adding plus 1 to make sure that it doesn't start at 1
                       Console.WriteLine((i+1)+"#: "+line[i]);
                    }

                    //Printing the whole loop
                    foreach (string lines in line)
                    {
                        sum += int.Parse(lines);
                    }
                    average = sum / counter;
                    //Outputting the sum of all of the numbers
                    Console.WriteLine("The Sum is: "+sum);
                    //Outputting the average of all of the numbers
                    Console.WriteLine("The Average is: "+average );


                }
               
            }*/

            //Opgave 20.2
            //Using the streamreader for reading the Boxes.txt file
            using (StreamReader BoxReader = new StreamReader("Boxes.txt"))
            {
                string PlaceHolderBox;
                string[] boxes = new string[3];
                List<Box> boxList = new List<Box>();
                for (int i = 0;BoxReader.EndOfStream == false; i++)
                {
                    PlaceHolderBox = BoxReader.ReadLine();
                    boxes = PlaceHolderBox.Split(',');
                    boxList.Add(new Box(int.Parse(boxes[0]),int.Parse(boxes[1]),int.Parse(boxes[2])));
                    Console.WriteLine(boxList[i]);
                    Console.WriteLine("The Height of the box is: "+boxes[0]+" "+"The Length of the box is: "+boxes[1]+" "+"The Width of the box is: "+boxes[2]);
                }              
                
                
                
            }

        }
    }
}
