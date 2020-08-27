using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE3_VariablesAndExpressions
{
    // Class Program
    // Author: Jailyn Talavera
    // Purpose: PE3 Variables & Expressions
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: answer to question 5 
        // Restrictions: None
        static void Main(string[] args)
        {

            //prompt user to input 4 numbers
            Console.WriteLine("Please input 4 numbers");

            //a string is assigned to each of the numbers inputed by the user 
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            string input3 = Console.ReadLine();
            string input4 = Console.ReadLine();

            //converting all the strings to ints
            int num1 = Convert.ToInt32(input1);
            int num2 = Convert.ToInt32(input2);
            int num3 = Convert.ToInt32(input3);
            int num4 = Convert.ToInt32(input4);

            //getting the product of all the numbers
            int result = num1 * num2 * num3 * num4;

            //displaying on the console the product
            Console.WriteLine(input1 +  " * " + input2 + " * " + input3 + " * " + input4 + " = " + result);

        }
    }
}
