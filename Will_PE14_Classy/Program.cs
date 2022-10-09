using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Will_PE14_Classy
{
    //Class: Program
    //Author: Nick Will
    //Purpose: Demonstrates use of classes, interfaces, and their methods
    //Restrictions: None
    internal class Program
    {
        public interface myInterface
        {
            void myMethod();
        }

        public class Class1 : myInterface
        {
            public void myMethod()
            {
                Console.WriteLine("This is the first class's implementation of the method");
            }
        }

        public class Class2 : myInterface
        {
            public void myMethod()
            {
                Console.WriteLine("This is the second class's implementation of the method");
            }
        }

        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            Class2 class2 = new Class2();

            MyMethod(class1);
            MyMethod(class2);

        }

        public static void MyMethod(Object myObject)
        {
            if (myObject is myInterface)
            {
                myInterface thisInterface = (myInterface)myObject;
                thisInterface.myMethod();
            }
        }
    }
}
