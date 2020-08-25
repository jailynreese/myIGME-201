using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquashTheBugs
{
    // Class Program
    // Author: Jailyn Talavera
    // Purpose: Bug squashing exercise
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: Loop through the numbers 1 through 10
        //          Output N/(N-1) for all 10 numbers        
        //          and list all numbers processed
        // Restrictions: None
        static void Main(string[] args)
        {
            //declare int counter
            //Compile-time error: missing semicolon at the end of the statement 
            //logical error: in order for the solutions to be doubles, i needs to be a double
            // int i = 0
            double i = 0;

            //new placement for declaring string to hold all numbers
            //logical error: the string needs to be declared outside the loop in order for all the numbers to be stored
            string allNumbers = null;

            //loop through the numbers 1 through 10
            //logical error: the loop doesn’t go all the way to 10; the conditional statement has to be i <= 10.            
            //for ( i = 1; i < 10; ++i )
            for (i = 1; i <= 10; ++i)            
            {
                //declare string to hold all numbers
                //string allNumbers = null;

                // output explanation of calculation  
                //compile-time error: i - 1 needs parenthesis around it
                //Console.Write(i + "/" + i - 1 + " = ");
                Console.Write(i + "/" + (i - 1) + " = ");

                
                // output the calculation based on the numbers  
                //run-time error: compute can't divide by zero, so we have to make a special case for when i = 1
                //Console.WriteLine(i / (i-1));
                if(i != 1)
                {
                    //need a double in order for i/(i - 1) to print as a decimal
                    double num = (i / (i - 1));
                    Console.WriteLine(num);

                } else
                {
                    Console.WriteLine("undefined");
                }

                // concatenate each number to allNumbers                
                allNumbers += i + " ";

                // increment the counter 
                //logical error: unneccesary becuase we already increment when declaring the loop
                //i = i + 1;            
            }
            // output all numbers which have been processed
            //compile-time error: missing + between string and allNumbers
            Console.WriteLine("These numbers have been processed: " + allNumbers);
        }
    }
}
