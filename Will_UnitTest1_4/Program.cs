using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Timer = System.Timers.Timer;

namespace Will_UnitTest1_4
{
    //Class: Program
    //Author: Nick Will
    //Purpose: Demonstrate the use of a timer for questions
    //Restrictions: None
    internal class Program
    {
        //Method: Main
        //Purpose: Asks the user a variety of timed questions
        //Restrictions: None
        static void Main(string[] args)
        {
            String answer = "";
            String correctAns = "";

            Timer timeoutTimer;
            bool timeOut = false;

            start:

            Console.Write("\nChoose your question (1-3): ");
            answer = Console.ReadLine();

            Console.WriteLine("You have 5 seconds to answer the following question:");

            if (Convert.ToInt32(answer) == 1)
            {
                Console.WriteLine("What is your favorite color? ");
                correctAns = "black";
            }

            if (Convert.ToInt32(answer) == 2)
            {
                Console.WriteLine("What is the answer to life, the universe and everything? ");
                correctAns = "42";
            }

            if (Convert.ToInt32(answer) == 3)
            {
                Console.WriteLine("What is the airspeed velocity of an unladed swallow? ");
                correctAns = "What do you mean? African or European swallow?";
            }

            timeoutTimer = new Timer(5000);

            timeoutTimer.Elapsed += (object sender, ElapsedEventArgs e) =>
            {
                Console.WriteLine("Time's up!");
                Console.WriteLine("Please press enter.");
                timeOut = true;
                timeoutTimer.Stop();

            };

            answer = "";

            timeoutTimer.Start();

            while (answer.Equals("") && !timeOut)
            {
                answer = Console.ReadLine();
            }

            timeoutTimer.Stop();

            if (answer.ToLower().Equals(correctAns.ToLower()))
            {
                Console.WriteLine("Well done!");
            }
            else
            {
                Console.WriteLine($"Wrong!\tThe answer is: {correctAns}");
            }

            Console.Write("\nPlay again? ");
            answer= Console.ReadLine();
            
            if(answer.ToLower().Equals("yes") || answer.ToLower().Equals("yup"))
            {
                goto start;
            }

        }
    }
}
