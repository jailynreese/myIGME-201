using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl2
{
    // Class Program
    // Author: Jailyn Talavera
    // Purpose: PE4 Flow Control 
    // Restrictions: None
    
    class Program
    {
        // Method: Main
        // Purpose: answer to exercise 1
        // Restrictions: None
        static void Main(string[] args)
        {

            //test var for the while loop
            bool greaterThan = false;

            Console.WriteLine("Please input 2 numbers that are greater than 10");

            //final int var
            int input1 = 0;
            int input2 = 0;

            //keeps running until the user inputs 2 values that are both greater than 10
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

                //if the numbers aren't greater than 10
                else
                {
                    Console.WriteLine("Please enter 2 new numbers that are greater than 10");
                }
             }

            //prints the 2 values that are greater than 10
            Console.WriteLine(input1 + " & " + input2 + " are greater than 10."); 
        }
    } 
}
