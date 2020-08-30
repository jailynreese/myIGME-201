using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl2
{
    //exercise 1 for FLow Control
    class Program
    {
        static void Main(string[] args)
        {

            //testc var for teh while loop
            bool greaterThan = false;

            Console.WriteLine("Please input 2 numbers that are greater than 10");

            //final int var
            int input1 = 0;
            int input2 = 0;

            while (!greaterThan)
            { 
                //reads the input
                string num1 = Console.ReadLine();
                string num2 = Console.ReadLine();

                //convert to int
                input1 = int.Parse(num1);
                input2 = int.Parse(num2);

                //if both are greater than 10, 
                if ((input1 > 10) && (input2 > 10))
                {
                    greaterThan = true;
                }
                else
                {
                    Console.WriteLine("Please enter 2 new numbers that are greater than 10");
                }
             }

            Console.WriteLine(input1 + " & " + input2 + " are greater than 10.");
        }
    } 
}
