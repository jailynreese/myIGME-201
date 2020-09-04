using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Madlibs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numLibs = 0;
            int cntr = 0;
            int nChoice = 0;

            StreamReader input;

            // open the template file to count how many Mad Libs it contains
            input = new StreamReader("c:\\templates\\MadLibsTemplate.txt");

            string line = null;
            while ((line = input.ReadLine()) != null)
            {
                ++numLibs;
            }

            // close it
            input.Close();

            // only allocate as many strings as there are Mad Libs
            string[] madLibs = new string[numLibs];

            // read the Mad Libs into the array of strings
            input = new StreamReader("c:\\templates\\MadLibsTemplate.txt");

            line = null;
            while ((line = input.ReadLine()) != null)
            {
                // set this array element to the current line of the template file
                madLibs[cntr] = line;

                // replace the "\\n" tag with the newline escape character
                madLibs[cntr] = madLibs[cntr].Replace('\n', '\n');

                ++cntr;
            }

            input.Close();

            bool letsPlay = false;

            //asks if the user wants to play
            Console.WriteLine("Do you want to play Mad Libs?");
            string answer = Console.ReadLine();
            answer.Trim();

            if (String.Compare(answer, "yes") == 1)
            {
                letsPlay = true;
            }

            //while loop for while the user wants to play
            while (letsPlay)
            {

                // prompt the user for which Mad Lib they want to play (nChoice)
                Console.WriteLine("Which Mad Lib would you like to play? Pick from 1-5");

                //while loop ensures user puts in a number 1-5 for choice
                //nChoice = 0
                while (nChoice <= 0 | nChoice > 5)
                {
                    //reads input from user 
                    string choice = Console.ReadLine();

                    //changes value of nChoice if the value user inputs is valid
                    if (int.TryParse(choice, out nChoice))
                    {
                        nChoice = int.Parse(choice);

                        //if not valid, makes them input again
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid choice. Please enter a number that's 1-5");
                    }
                }


                // split the Mad Lib into separate words
                string[] words = madLibs[nChoice].Split(' ');
                //final string
                string[] final = new string[words.Length - 1];
                int iteration = 0;

                foreach (string word in words)
                {
                    // if word is a placeholder
                    if (word[0] == '{')
                    {
                        string helper = " ";
                        char[] remove = { '{', '}' };
                        helper = word.Trim(remove);
                        helper.Replace("_", " ");

                        // prompt the user for the replacement
                        Console.WriteLine("Please enter a " + word);

                        //reads line and replaces prompt in string for the user's input 
                        string userIn = Console.ReadLine();
                        final[iteration] = userIn;

                    } else
                    {
                        final[iteration] = words[iteration];
                    }

                    iteration++;
                }
            }
            //if the user doesn't want to play or is done playing
            Console.WriteLine("Goodbye!");
        }
    }
}
