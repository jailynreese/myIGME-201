using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classy
{
    //Class: Program
    //Author: Jailyn Talavera
    //Purpose: PE14 lLassy
    //Restrictions: None
    class Program
    {
        //Method: Main
        //Purpose: creates instances of 2 classes (kid1 and kid2) and myMethod
        //Restrictions: None
        static void Main(string[] args)
        {
            kid1 firstHappy = new kid1();
            kid2 secondHappy = new kid2();

            myMethod(firstHappy);
            myMethod(secondHappy);

        }

        public static void myMethod(Parent interf)
        {
            interf.Happy();
        }
    }

    public abstract class Classy
    {
        private string mood 
        { 
            get;
            set; 
        }
        
    }

    public interface Parent
    {
        string Happy();
        
    }

    public class kid1: Parent
    {
        public string Happy()
        {
            return "I'm happy!! ";
        }
    }

    public class kid2: Parent
    {
        public string Happy()
        {
            return "teehee :))";
        }
    }
}
