using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquashTheBugs
{
    // Class Program
    // Author: David Schuh
    // Editor: Nick Will
    // Purpose: Bug squashing exercise
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: Loop through the numbers 1 through 10 
        //          Output N/(N-1) for all 10 numbers
        //          and list all numbers processed
        // Restrictions: None
        static void Main(string[] args)
        {
            // declare int counter
            //int i = 0 
            int i = 0; // compile time error: missing semicolon

            string allNumbers = null; //compile time error: must be declared outside of loop

            // loop through the numbers 1 through 10
            //for (i = 1; i < 10; ++i)
            for (i = 1; i <=10; i++) //logic error: must include 10 in the loop
            {
                // declare string to hold all numbers
                //string allNumbers = null;

                // output explanation of calculation
                //Console.Write(i + "/" + i - 1 + " = ");
                Console.Write(i + "/" + (i - 1) + " = "); //compile time error: need parenthesis

                // output the calculation based on the numbers
                //Console.WriteLine(i / (i - 1));
                if (i == 1)
                {
                    Console.WriteLine("NA");
                }
                else
                {
                    Console.WriteLine(i / (i - 1.0));//added 1.0 to get actual decimal values
                } //Run-time error: cannot divide by zero

                // concatenate each number to allNumbers
                allNumbers += i + " ";

                // increment the counter
                //i = i + 1; logic error: don't need to increment counter because it's a for loop

            }

            // output all numbers which have been processed
            //Console.WriteLine("These numbers have been processed: " allNumbers);
            Console.WriteLine("These numbers have been processed: " + allNumbers); //compile time error: need + operand
        }
    }
}

