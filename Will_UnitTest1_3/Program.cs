using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Will_UnitTest1_3
{
    delegate double myRound(double num, int precision);

    //Class: Program
    //Author: Nick Will
    //Purpose: To demonstrate the use of delegate methods
    //Restrictions: None
    static internal class Program
    {
        //Method: Main
        //Purpose: Uses a delegate method for Math.Round
        //Restrictions: None
        static void Main(string[] args)
        {
            myRound mr = new myRound(Math.Round);

            double result = mr(2.57896320, 2);

            Console.WriteLine(result);
        }
    }
}
