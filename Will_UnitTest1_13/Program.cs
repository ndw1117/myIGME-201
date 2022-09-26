using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Will_UnitTest1_13
{
    //Class: Program
    //Author: Nick Will
    //Purpose: Manages an employee's salary
    //Restrictions: None
    static internal class Program
    {
        struct employee
        {
            public String sName;
            public double dSalary;

            public employee(string name, double salary)
            {
                this.sName = name;
                this.dSalary = salary;
            }
        }

        //Method: Main
        //Purpose: Handles salary information
        //Restrictions: None
        static void Main(string[] args)
        {
           employee myEmployee = new employee("", 30000);

            Console.Write("Enter your name: ");
            myEmployee.sName = Console.ReadLine();

            if (GiveRaise(ref myEmployee))
            {
                Console.WriteLine($"Congratulations on your raise! Your new salary is ${myEmployee.dSalary}");
            }
            else
            {
                Console.WriteLine($"Your salary is ${myEmployee.dSalary}");
            }
        }

        static bool GiveRaise(ref employee myEmployee)
        {
            if (myEmployee.sName.Equals("Nick"))
            {
                myEmployee.dSalary += 19999.99;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
