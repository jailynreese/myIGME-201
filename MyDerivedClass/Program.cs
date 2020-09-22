using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClass;

namespace MyDerivedClass
{
    // Class Program
    // Author: Jailyn Talavera
    // Purpose: PE12 Defining Class Members
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: solution to #3
        // Restrictions: None
        static void Main(string[] args)
        {
            MyDerivedClass strings = new MyDerivedClass();
            string output = strings.GetString();
            Console.WriteLine(output);
        }
    }

    //inherits Class1 (MyClass)
    class MyDerivedClass : Class1
    {

        //overring getString
        public override string GetString()
        {
            //returning string from base + text
            return base.GetString() + " (output from the derived class)";
        }
    }
}
