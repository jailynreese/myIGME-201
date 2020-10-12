using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//add sewing library
using SewingLib;

namespace Sewing
{
    // Class Program
    // Author: Jailyn Talavera
    // Purpose: Unit Test 2 
    // Restrictions: None
    class program
    {
        // Method: Main
        // Purpose: answer to #10
        // Restrictions: None
        static void Main(string[] args)
        {
            //instances of 2 child objects
            Hat bucketHat = new Hat();
            Dress gown = new Dress();

            //calling MyMethod
            MyMethod(bucketHat);
            MyMethod(gown);
        }

        //MyMethod w/ parent class as parameter
        public static void MyMethod(Material things){
            things.CutFabric();
        }
    }
}


