using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Will_UnitTest1_12
{
    //Class: Program
    //Author: Nick Will
    //Purpose: Manages an employee's salary
    //Restrictions: None
    static internal class Program
    {
        //Method: Main
        //Purpose: Handles salary information
        //Restrictions: None
        static void Main(string[] args)
        {
            String sName = "";
            double dSalary = 30000;

            Console.Write("Enter your name: ");
            sName = Console.ReadLine();

            if (GiveRaise(sName, ref dSalary))
            {
                Console.WriteLine($"Congratulations on your raise! Your new salary is ${dSalary}");
            }
            else
            {
                Console.WriteLine($"Your salary is ${dSalary}");
            }
        }

        static bool GiveRaise(String name, ref double salary)
        {
            if (name.Equals("Nick"))
            {
                salary += 19999.99;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
