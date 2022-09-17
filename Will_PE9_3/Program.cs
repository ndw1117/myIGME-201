using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Will_PE9_3
{
    //Class: Program
    //Author: Nick Will
    //Purpose: Uses a delegate class to impersonate the Console.ReadLine() function.
    //Restrictions: None
    static internal class Program
    {
        delegate string DelegateReadLine();

        //Method: Main
        //Purpose: Calls the delegate method to get input from the user.
        //Restrictions: None
        static void Main(string[] args)
        {
            string input = "";
            DelegateReadLine readLine = new DelegateReadLine(Console.ReadLine);

            Console.Write("Enter input: ");
            input = readLine();

            Console.WriteLine(input);
        }
    }
}
