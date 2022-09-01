using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Will_PE3_Variables_And_Expressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 1;
            int variable;

            for (int i = 0; i < 4; i++)
            {
                
                Console.Write($"Enter int value #{i + 1}: ");
                variable = Convert.ToInt32(Console.ReadLine());
                
                total *= variable;
                Console.WriteLine("");

            }

            Console.WriteLine($"The product of the numbers is {total}");
            
            

        }
    }
}
