using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    public class Class1
    {
        private string myString;

        public string MyString
        {
            get 
            {
                return null;
            }
            set
            {
                myString = value;
            }
               
        }
        public virtual string GetString()
        {

          return myString; 

        }

    }
}
