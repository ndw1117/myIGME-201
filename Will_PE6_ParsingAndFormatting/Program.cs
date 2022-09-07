using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Will_PE6_ParsingAndFormatting
{
    //Class: Program
    //Author: Nick Will
    //Purpose: Create a number guessing game based on random integers
    //Restrictions: None
    static internal class Program
    {
        //Method: Main
        //Purpose: Generate a random integer and have the user try to guess it
        //Restrictions: None
        static void Main(string[] args)
        {
            Random rand = new Random();

            int randomNumber = rand.Next(0, 101);

            String input = null;
            int guess, guesses = 0;

            Console.WriteLine(randomNumber);

            for (int i = 0; i < 8; i++)
            {
                do
                {
                    Console.Write("Guess #{0} - Enter your integer: ", i + 1);
                    input = Console.ReadLine();
                    try
                    {
                        guess = Convert.ToInt32(input);
                        if (guess >= 0 && guess <= 100)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input! Please enter an integer between 0 and 100 (inclusive)");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Invalid input! Please enter an integer between 0 and 100 (inclusive)");
                    }
                }
                while (true);

                if (guess > randomNumber)
                {
                    Console.WriteLine("Too high.");
                }
                else if (guess < randomNumber)
                {
                    Console.WriteLine("Too low");
                }
                else if (guess == randomNumber)
                {
                    Console.Write("\nCorrect!");
                    guesses = i + 1;
                    break;
                }

            }

            if (guesses == 0)
            {
                Console.WriteLine("\nYou ran out of turns. The number was {0}.", randomNumber);
            }
            else
            {
                Console.WriteLine(" You won in {0} turns", guesses);
            }
        }
    }
}
