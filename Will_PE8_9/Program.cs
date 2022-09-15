using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Will_PE8_9
{
    //Class: Program
    //Author: Nick Will
    //Purpose: Demonstrate knowledge of inserting into sepcific positions of strings based on spaces
    //Restrictions: None

    static internal class Program
    {
        //Method: Main
        //Purpose: Place double quotes around each word in a given string
        //Restrictions: None
        static void Main(string[] args)
        {
            string s = "";

            Console.Write("Enter a string: ");
            s = Console.ReadLine();

            s = "\"" + s.Replace(" ", "\" \"") + "\"";

            Console.WriteLine(s);

        }
    }
}
