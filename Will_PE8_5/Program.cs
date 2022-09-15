using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Will_PE8_5
{
    //Class: Program
    //Author: Nick Will
    //Purpose: To demonstrate the use of a 3-dimensional array in a computation
    //Restrictions: None
    static internal class Program
    {
        //Method: Main
        //Purpose: Computes a formula for specific ranges of variables using a 3-dimensional array
        //Restrictions: None
        static void Main(string[] args)
        {
            double x = 0;
            double y = 0;
            double z = 0;

            int nX = 0;
            int nY = 0;

            double[,,] values = new double[21,31,3];

            for (x = -1; x <= 1; x += 0.1, nX++)
            {
                x = Math.Round(x, 1);
                nY = 0;

                for (y = 1; y <= 4; y += 0.1, ++nY)
                {
                    y = Math.Round(y, 1);

                    z = (3 * Math.Pow(y, 2)) + (2 * x) - 1;
                    z = Math.Round(z, 3);

                    values[nX, nY, 0] = x;
                    values[nX, nY, 1] = y;
                    values[nX, nY, 2] = z;

                }
            }
        }
    }
}
