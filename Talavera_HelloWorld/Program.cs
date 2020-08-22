using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talavera_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! \n");

            int age = 73;
            int age2 = 34;
            int age3 = age * age2;

            Console.WriteLine(age + " * " + age2 + " = " + age3 + "\n");

            string bff = "DONKEYY";
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Shrek yelled, \"" + bff + "!!!\" ");
            }

            Console.WriteLine();
        }
    }
}
