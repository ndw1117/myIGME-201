using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Will_PE8_7
{
    //Class: Program
    //Author: Nick Will
    //Purpose: Demonstrate string manipulation in C#
    //Restrictions: None
    static internal class Program
    {
        //Method: Main
        //Purpose: Takes a string from the user and outputs a string with the characters in reverse order
        //Restrictions: None
        static void Main(string[] args)
        {
            string input = "";
            string output = "";

            Console.Write("Enter a string: ");
            input = Console.ReadLine();

            foreach(char c in input.Reverse())
            {
                output += c;
            }

            Console.WriteLine(output);
        }
    }
}
