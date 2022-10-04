using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Will_PE12_3
{
    //Class: Program
    //Author: Nick Will
    //Purpose: Demonstrates an understanding of classes.
    //Restrictions: None
    internal class Program
    {
        //Class: MyClass
        //Purpose: The class to be derived from
        //Restrictions: None
        public class MyClass
        {
            private string myString;

            public string MyString
            {
                set
                {
                    myString = value;
                }
            }

            public virtual string GetString()
            {
                return myString;
            }

        }

        //Class: MyDerivedClass
        //Purpose: Derives itself from MyClass and overrides the GetString() method
        //Restrictions: None
        public class MyDerivedClass : MyClass
        {
            public override string GetString()
            {
                return (base.GetString() + " (output from the derived class)");
            }
        }

        //Method: Main
        //Purpose: Instantiates a MyDerivedClass and outputs a string
        //Restrictions: None
        static void Main(string[] args)
        {
            MyDerivedClass myDerivedClass = new MyDerivedClass();

            Console.WriteLine(myDerivedClass.GetString());
        }
    }
}
