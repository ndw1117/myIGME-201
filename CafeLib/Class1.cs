using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace CafeLib
{
    //Class: HotDrink
    //Purpose: Provides information on a hot beverage in the cafe
    //Restrictions: None
   public abstract class HotDrink
   {
        public bool instant;
        public bool milk;
        private byte sugar;
        public string brand;
        public string size;
        public Customer customer;

        public virtual void AddSugar(byte amount)
        {
            this.sugar += amount;
        }

        public abstract void Steam();

        public HotDrink()
        {
            this.instant = false;
            this.milk = false;
            this.sugar = 0;
            this.size = "";
            this.customer = new Customer();
        }

        public HotDrink(string brand)
        {
            if (brand == "Folgers")
            {
                this.instant = true;
            }

            this.brand = brand;

            this.milk = false;
            this.sugar = 0;
            this.size = "";

            this.customer = new Customer();
        }

   }

    //Interface: IMood
    //Purpose: An interface for the mood of a person
    //Restrictions: None
    public interface IMood
    {
        string Mood { get; }
    }

    //Interface: ITakeOrder
    //Purpose: An interface for the action of taking an order
    //Restrictions: None
    public interface ITakeOrder
    {
        void TakeOrder();
    }

    //Class: Customer
    //Purpose: A class for a customer's information
    //Restrictions: None
    public class Customer : IMood
    {
        public string name;
        public string creditCardNumber;

        public string Mood { get; }
    }

    //Class: Waiter
    //Purpose: A class for information on a waiter
    //Restrictions: None
    public class Waiter : IMood
    {
        public string name;

        public string Mood { get; }

        public void ServeCustomer(HotDrink cup)
        {
            Console.WriteLine($"{name} serves a {cup} to {cup.customer.name}");
        }
    }

    //Class: CupOfCoffee
    //Purpose: A class for infomration on a cup of coffee
    //Restrictions: None
    public class CupOfCoffee : HotDrink, ITakeOrder
    {
        public string beanType;

        public override void Steam()
        {
            Console.WriteLine("The coffee is steaming.");
        }

        public void TakeOrder()
        {
            Console.WriteLine("Order is taken.");
        }

        public CupOfCoffee(string brand) : base(brand)
        {
            beanType = "";
        }

    }

    //Class: CupOfTea
    //Purpose: A class for information on a cup of tea
    //Restrictions: None
    public class CupOfTea : HotDrink, ITakeOrder
    {
        public string leafType;
        public bool customerIsWealthy;

        public override void Steam()
        {
            Console.WriteLine("The cup of tea is steaming.");
        }

        public void TakeOrder()
        {
            Console.WriteLine("Order is taken.");
        }

        public CupOfTea(bool customerIsWealthy)
        {
            this.leafType = "";
            this.customerIsWealthy = customerIsWealthy;
        }
    }

    //Class: CupOfCocoa
    //Purpose: A class for information on a cup of cocoa
    //Restrictions: None
    public class CupOfCocoa : HotDrink, ITakeOrder
    {
        public static int numCups;
        public bool marshmallows;
        private string source;

        public string Source
        {
            set
            {
                source = value;
            }
        }

        public override void Steam()
        {
            Console.WriteLine("The cup of cocoa is steaming.");
        }

        public override void AddSugar(byte amount)
        {
            this.AddSugar(amount);
        }

        public void TakeOrder()
        {
            Console.WriteLine("Order is taken.");
        }

        public CupOfCocoa(bool marshmallows) : base("Expensive Organic Brand")
        {
            this.marshmallows = marshmallows;
            this.source = "";
        }
    }
}
