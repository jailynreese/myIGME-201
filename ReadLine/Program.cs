using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadLine
{
    // Class Program
    // Author: Jailyn Talavera
    // Purpose: PE9 Functions
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: solution to #3
        // Restrictions: None

        //delegate declared
        delegate string readLine();

        static void Main(string[] args)
        {
            //declare & construct delegate variable;
            readLine readInput = new readLine(Console.ReadLine);

            //call delegate readInput & assign input to string
            string input = readInput();

        }
    }
}
