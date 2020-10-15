using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple
{
    class Program
    {
        //Class: Program
        //Author: Jailyn Talavera
        //Purpose: Unit Exam 
        //Restrictions: none
        static void Main(string[] args)
        {
            SortedList<(double, double, double), double> wxyz = new SortedList<(double, double, double), double>();

            for(double w = -2; w <= 0; w += 0.2)
            {
                //round w to 1 decimal place to prevent rounding errors
                w = Math.Round(w, 1);

                for (double y = -1; y <= 1; y += 0.1)
                {
                    //round y to 1 decimal place to prevent rounding errors
                    y = Math.Round(y, 1);

                    for (double x = 0; x <= 4; x += 0.1)
                    {
                        //round x to 1 decimal place to prevent rounding errors
                        x = Math.Round(x, 1);

                        //calculate z value
                        double yVal = y * y * y * 4;
                        double xVal = x * x * 2;
                        double wVal = 8 * w;
                        double z = yVal + xVal - wVal + 7;

                        //round calculation to 2 decimal places
                        z = Math.Round(z, 2);

                        //assigning values to sortedList
                        wxyz[(w, y, x)] = z;
                    }
                }
            }

        }
    }
}
