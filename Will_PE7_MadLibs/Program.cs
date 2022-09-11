using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


//DISCLAIMER: Code from David Schuh's MadLibHints.cs is referenced in this file.
namespace Will_PE7_MadLibs
{
    //Class: Program
    //Author: Nick Will
    //Purpose: Use a template file with input from the user to generate a mad libs game
    //Restrictions: None
   static class Program
    {
        //Method: Main
        //Purpose: Read in template file, prompt user for input, output resulting mad lib
        //Restrictions: None
        static void Main(string[] args)
        {
            int numLibs = 0;
            int cntr = 0;
            int nChoice = 0;
            int i = 0;

            string finalStory = "";
            string word;
            string name;
            string answer;

            StreamReader input;

            //ask the user if they want to play Mad Libs
            do
            {
                Console.Write("Hello! Would you like to play Mad Libs? ");
                answer = Console.ReadLine();

                if (answer.ToLower().Equals("yes") || answer.ToLower().Equals("no"))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter either yes or no.");
                }
            }
            while (true);

            //exit the program if the user said no
            if(answer.Equals("no"))
            {
                Console.WriteLine("Okay, bye!");
                Environment.Exit(0);
            }

            // open the template file to count how many Mad Libs it contains
            input = new StreamReader("c:\\templates\\MadLibsTemplate.txt");

            string line = null;
            while ((line = input.ReadLine()) != null)
            {
                ++numLibs;
            }

            // close it
            input.Close();

            // only allocate as many strings as there are Mad Libs
            string[] madLibs = new string[numLibs];

            // read the Mad Libs into the array of strings
            input = new StreamReader("c:\\templates\\MadLibsTemplate.txt");

            line = null;
            while ((line = input.ReadLine()) != null)
            {
                // set this array element to the current line of the template file
                madLibs[cntr] = line;

                // replace the "\\n" tag with the newline escape character
                madLibs[cntr] = madLibs[cntr].Replace("\\n", "\n");

                ++cntr;
            }

            input.Close();

            //prompts the user for their name
            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            // prompt the user for which Mad Lib they want to play (nChoice)
            do
            {
                try
                {
                    Console.Write("Enter which Mad Lib you want to play (1-{0}): ", numLibs);
                    nChoice = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("You did not enter an integer.", numLibs);
                }

                if (nChoice >= 1 && nChoice <= numLibs)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter an integer between 1 and {0}!", numLibs);
                }
            }
            while (true);

            // split the Mad Lib into separate words
            string[] words = madLibs[nChoice - 1].Split(' ');

            for (i = 0; i < words.Length; i++)
            {
                word = words[i];

                // if word is a placeholder
                if (word[0] == '{')
                {
                    word = word.Replace("{", "").Replace("}", "").Replace("_", " ");
                    // prompt the user for the replacement
                    Console.Write("Input a {0}: ", word);
                    // and append the user response to the result string
                    finalStory += Console.ReadLine() + " ";
                }
                // else append word to the result string
                else
                {
                    finalStory += (word + " ");
                }
            }

            Console.WriteLine(finalStory);
        }
    }
}