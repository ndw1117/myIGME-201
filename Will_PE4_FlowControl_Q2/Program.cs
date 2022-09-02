using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Will_PE4_FlowControl_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            bool validInt = false;
            bool validNums = false;

            do
            {
                do
                {
                    Console.Write("Enter your first number: ");
                    try
                    {
                        num1 = int.Parse(Console.ReadLine());
                        validInt = true;
                    }
                    catch
                    {
                        Console.WriteLine("Please enter an integer value.");
                    }
                }
                while (validInt == false);

                validInt = false;

                do
                {
                    Console.Write("Enter your second number: ");
                    try
                    {
                        num2 = int.Parse(Console.ReadLine());
                        validInt = true;
                    }
                    catch
                    {
                        Console.WriteLine("Please enter an integer value.");
                    }
                }
                while (validInt == false);

                Console.WriteLine("Number 1: {0}\tNumber 2: {1}", num1, num2);

                if (num1 > 10 && num2 > 10)
                {
                    Console.WriteLine("Both numbers are greater than 10. Please input new numbers.");
                }
                else
                {
                    validNums = true;
                }
            }
            while (validNums == false);
        }

    }
}
