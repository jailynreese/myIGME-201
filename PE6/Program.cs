using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE6
{
    // Class Program
    // Author: Jailyn Talavera
    // Purpose: PE6 Parsing & Formatting
    // Restrictions: None
    class Program
    {
        // Method: Main

        /* Purpose: number guessing game where program will generate a random integer 
        number between 0 and 100 (inclusive) and a player will try to guess it*/

        // Restrictions: None
        static void Main(string[] args)
        {
            Random rand = new Random();

            // generate a random number between 0 inclusive and 101 exclusive
            int randomNumber = rand.Next(0, 101);

            //print random number
            Console.WriteLine(randomNumber);

            //bool for if the user ran out of turns
            bool lost = true;

            //loop for the user's 8 turns
            for (int i = 1; i <= 8; i++)
            {
                Console.WriteLine("Turn #" + i + ": Enter your guess: ");

                //reads user's guess
                String guess = Console.ReadLine();

                //convert string to int so it can be compared to random number
                int num = int.Parse(guess);

                //if statement to compare guess to randomNumber
                //if the guess is the correct answer
                if (num == randomNumber)
                {
                    Console.WriteLine();
                    Console.WriteLine("Correct! You won in " + i + " turns.");
                    lost = false;
                    break;
                }

                //if the guess was too high & within appropriate range
                else if ((100 > num) && (num > randomNumber))
                {
                    Console.WriteLine("Too high");
                }

                //if the guess was too low & within appropriate range
                else if ((0 < num) && (num < randomNumber))
                {
                    Console.WriteLine("Too low.");
                }

                //if the guess was not within 0 - 100 (invalid guess)
                //invalid guess lets them have another turn 
                else
                {
                    Console.WriteLine("Invalid guess - try again");
                    i--;
                }
            }

            //msg is the user doesn't guess right after 8 turns
            if (lost)
            {
                Console.WriteLine();
                Console.WriteLine("You ran out of turns. The number was "+ randomNumber + ".");
            }
        }
    }
}
