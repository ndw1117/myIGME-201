using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT1_BugSquash
{
    class Program
    {
        // Calculate x^y for y > 0 using a recursive function
        static void Main(string[] args)
        {
            string sNumber;
            int nX;
            //int nY
            int nY; //Compile-Error: Neeed semicolon.
            int nAnswer;

            //Console.WriteLine(This program calculates x ^ y.);
            Console.WriteLine("This program calculates x ^ y."); //Compile-Error: Need quotation marks to make a string

            do
            {
                Console.Write("Enter a whole number for x: ");
                //Console.ReadLine();
                sNumber = Console.ReadLine(); //Compile error: The input wasn't being assigned to sNumber before it was used
            } while (!int.TryParse(sNumber, out nX));

            do
            {
                Console.Write("Enter a positive whole number for y: ");
                sNumber = Console.ReadLine();
                //} while (int.TryParse(sNumber, out nX));
            } while (!int.TryParse(sNumber, out nY)); //Logical Error: Need to set sNumber equal to nY, also need ! opperand

            // compute the exponent of the number using a recursive function
            nAnswer = Power(nX, nY);

            //Console.WriteLine("{nX}^{nY} = {nAnswer}");
            Console.WriteLine($"{nX}^{nY} = {nAnswer}"); //Logical Error: Need $ sign
        }


        //int Power(int nBase, int nExponent)
        static int Power(int nBase, int nExponent) //Compile-Error: Need the static keyword since we are not instaniating
        {
            int returnVal = 0;
            int nextVal = 0;

            // the base case for exponents is 0 (x^0 = 1)
            if (nExponent == 0)
            {
                // return the base case and do not recurse
                returnVal = 0;
            }
            else
            {
                // compute the subsequent values using nExponent-1 to eventually reach the base case
                //nextVal = Power(nBase, nExponent + 1);
                nextVal = Power(nBase, nExponent - 1); //Logic Error: Need to subtract, not add

                // multiply the base with all subsequent values
                returnVal = nBase * nextVal;
            }

            //returnVal;
            return returnVal; //Compile-Error: Need to return returnVal here
        }
    }
}

