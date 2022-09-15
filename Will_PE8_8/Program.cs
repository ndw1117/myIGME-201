using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Will_PE8_8
{
    //Class: Program
    //Author: Nick Will
    //Purpose: Demonstrate knowledge of string replacement
    //Restrictions: None
    static internal class Program
    {
        //Method: Main
        //Purpose: Replaces all occurences of the word "no" in a given string with "yes"
        //Restrictions: None
        static void Main(string[] args)
        {
            string input = "";
            string output = "";

            Console.Write("Enter a string: ");
            input = Console.ReadLine();

            output = input.Replace("no", "yes").Replace("NO", "YES").Replace("No", "Yes").Replace("nO", "yES");
            Console.WriteLine(output);
        }
    }
}
