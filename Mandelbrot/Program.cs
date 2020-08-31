using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandelbrot
{
    //Class: Program
    //Author: Jailyn Talavera
    //Purpose: Mandelbrot project
    //Restrictions: none
    class Program
    {
        //Method: Main
        //Purpose: creates an image in console based on user input
        //Restrictions: None
        static void Main(string[] args)
        {
            //user's start and end values for imgCoord & realCoord
            double startIC = 0;
            double endIC = 0;
            double startRC = 0;
            double endRC = 0;

            //boolean for while loop
            bool validNum = false;

        //loops stops when user has inputed all valid values​
         while (!validNum)
            {
                //promts user for values & reads values
                Console.WriteLine("Please enter the values of the wanted image limits.");
                Console.WriteLine("For the imagCoor values, please enter values that are less than 2 and greater than -2. ");
                Console.WriteLine("Make sure that the start value is GREATER THAN your end value.");
                Console.WriteLine("Enter the imagCoor start value: ");
                string icStart = Console.ReadLine();
                Console.WriteLine("Enter the imagCoor end value: ");
                string icEnd = Console.ReadLine();
                
                Console.WriteLine("For the readCoor values, please enter values that are less than 2 and greater than -2. ");
                Console.WriteLine("Make sure that the start value is LESS THAN your end value.");
                Console.WriteLine("Enter the realCoor start value: ");
                string rcStart = Console.ReadLine();
                Console.WriteLine("Enter the realCoor end value: ");
                string rcEnd = Console.ReadLine();

                //convert strings to doubles
                startIC = Double.Parse(icStart);
                endIC = Double.Parse(icEnd);
                startRC = Double.Parse(rcStart);
                endRC = Double.Parse(rcEnd);
                
                //check that inputs are valid (within range and checks value)
                bool icGreater = startIC > endIC;
                bool rcGreater = startRC < endRC;
                bool inRange1 = (startIC > -2.0) && (startIC < 2.0);
                bool inRange2 = (endIC > -2.0) && (endIC < 2.0);
                bool inRange3 = (startRC > -2.0) && (startRC < 2.0);
                bool inRange4 = (endRC > -2.0) && (endRC < 2.0);

                //checks if all bool are true
                if (icGreater && rcGreater && inRange1 && inRange2 && inRange3 && inRange4)
                {
                    validNum = true;
                }
                else
                {
                    Console.WriteLine("One of the values you inputed is not valid. Please try again.");
                }
            }
         
            double realCoord, imagCoord;
            double realTemp, imagTemp, realTemp2, arg;
            int iterations;

            //creates intervals for the loops​
            double intervalsIC = (Math.Abs(startIC) + Math.Abs(endIC)) / 48;
            double intervalsRC = (Math.Abs(startRC) + Math.Abs(endRC)) / 80;
            
            for (imagCoord = startIC; imagCoord >= endIC; imagCoord -= intervalsIC)
            {
                for (realCoord = startRC; realCoord <= endRC; realCoord += intervalsRC)
                {
                    iterations = 0;
                    realTemp = realCoord;
                    imagTemp = imagCoord;
                    arg = (realCoord * realCoord) + (imagCoord * imagCoord);
                    while ((arg < 4) && (iterations < 40))
                    {
                        realTemp2 = (realTemp * realTemp) - (imagTemp * imagTemp)
                           - realCoord;
                        imagTemp = (2 * realTemp * imagTemp) - imagCoord;
                        realTemp = realTemp2;
                        arg = (realTemp * realTemp) + (imagTemp * imagTemp);
                        iterations += 1;
                    }
                    switch (iterations % 4)
                    {
                        case 0:
                            Console.Write(".");
                            break;
                        case 1:
                            Console.Write("o");
                            break;
                        case 2:
                            Console.Write("O");
                            break;
                        case 3:
                            Console.Write("@");
                            break;
                    }
                }
                Console.Write("\n");
            }
            
        }
    }
}
