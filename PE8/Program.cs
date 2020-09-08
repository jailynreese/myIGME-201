using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8
{
    //Class: Program
    //Author: Jailyn Talavera
    //Purpose: PE-8 More About Variables
    //Restrictions: None

    class Program
    {
        //Method: Main
        //Purpose: Solutions to problems 7-9
        //Restrictions: None
        static void Main(string[] args)
        {
            //solution to number 5
            //double for all the x, y, and z values
            double[, ,] xyz = new double[20, 631, 800];
            
            int xIndex = 0;
            int yIndex = 0;

            double z;

            for (double i = -1; i <= 1; i += 0.1)
            {
                for(double j = 1; j <= 4; j += 0.1)
                {
                    /*for(int k = 0; k <= 800; ++k)
                    {
                        double y = j * j * 3;
                        double x = 2 * i;
                        z = y + x - 1;

                        //commented this statement out because i am getting an out of bounds error
                       // xyz[xIndex, yIndex, k] = z;
                    }
                   ++yIndex; */

                    yIndex++;
                    Console.WriteLine(yIndex);

                }
                ++xIndex;
                
            }
            Console.WriteLine(xyz); 


            //problem 7
            Console.WriteLine("Enter a string");
            string input = Console.ReadLine();

            //string for final inverted string
            string final = "";

            //for loop rearranges the index of the chars in the string
            for (int i = input.Length - 1; i >= 0; i--)
            {
                final += input[i];
            }
            Console.WriteLine("inverted string: " + final);
            Console.WriteLine();


            //problem 8
            Console.WriteLine("Type \"no\"");
            String input2 = Console.ReadLine();
            input2 = input2.ToLower();
            input2 = input2.Trim();
            //while the user keeps typing no, the computer will keep responding with yes
            //the computer will only respond to no's that are changed in case or have white space
            while (input2 == "no")
            {
                Console.WriteLine("yes");
                input2 = Console.ReadLine();
                input2 = input2.ToLower();
                input2 = input2.Trim();
            }
            Console.WriteLine();


            //problem 9
            //puts quotations around each word
            Console.WriteLine("Please enter a sentence.");
            string phrase = Console.ReadLine();

            //array of words from input
            string[] words = phrase.Split(' ');

            //adds double quotes for every word in string
            //punctuation is included with the string closest to it
            foreach (var word in words)
            {
                System.Console.Write("\"" + word + "\" ");
            }
            Console.WriteLine();

        }
    }
}
