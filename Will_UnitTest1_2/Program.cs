using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Will_UnitTest1_2
{
    //Class: Program
    //Author: Nick Will
    //Purpose: Demonstrate a sorting method for strings
    //Restrictions: None
    static internal class Program
    {
        // the definition of the delegate function data type
        delegate String sortingFunction(String[] a);

        //Method: Main
        //Purpose: Uses a delegate function to sort the words of a given string in ascending or descending order
        //Restrictions: None
        static void Main(string[] args)
        {
            // declare the unsorted and sorted arrays
            String[] aUnsorted;
            String[] aSorted;

            // declare the delegate variable which will point to the function to be called
            sortingFunction findHiLow;

            Console.WriteLine("Enter a list of space-separated words");

            // read the space-separated string of words
            string sWords = Console.ReadLine();

            // split the string into the an array of strings which are the individual words
            string[] sWord = sWords.Split(' ');

            // set the size of the unsorted array
            int nUnsortedLength = sWord.Length;

            // now we know how many unsorted words there are
            // allocate the size of the unsorted array
            aUnsorted = new String[nUnsortedLength];

            // reset nUnsortedLength back to 0 to use as the index to store the words in the unsorted array
            nUnsortedLength = 0;
            foreach (string sThisWord in sWord)
            {
                // still skip the blank strings
                if (sThisWord.Length == 0)
                {
                    continue;
                }

                // store the value into the array
                aUnsorted[nUnsortedLength] = sThisWord;

                // increment the array index
                nUnsortedLength++;
            }

            // allocate the size of the sorted array
            aSorted = new String[nUnsortedLength];

            // prompt for <a>scending or <d>escending
            Console.Write("Ascending or Descending? ");
            string sDirection = Console.ReadLine();

            if (sDirection.ToLower().StartsWith("a"))
            {
                findHiLow = new sortingFunction(FindLowestValue);
            }
            else
            {
                findHiLow = new sortingFunction(FindHighestValue);
            }

            // start the sorted length at 0 to use as sorted index element
            int nSortedLength = 0;

            // while there are unsorted values to sort
            while (aUnsorted.Length > 0)
            {
                // store the lowest or highest unsorted value as the next sorted value
                aSorted[nSortedLength] = findHiLow(aUnsorted);

                // remove the current sorted value
                RemoveUnsortedValue(aSorted[nSortedLength], ref aUnsorted);

                // increment the number of values in the sorted array
                ++nSortedLength;
            }

            // write the sorted array of words
            Console.WriteLine("The sorted list is: ");
            foreach (String word in aSorted)
            {
                Console.Write($"{word} ");
            }

            Console.WriteLine();
        }

        // find the lowest value in the array of words
        static String FindLowestValue(String[] array)
        {
            // define return value
            String returnVal;

            // initialize to the first element in the array
            // (we must initialize to an array element)
            returnVal = array[0];

            // loop through the array
            foreach (String word in array)
            {
                // if the current value is less than the saved lowest value
                if (word.CompareTo(returnVal) < 0)
                {
                    // save this as the lowest value
                    returnVal = word;
                }
            }

            // return the lowest value
            return (returnVal);
        }

        static String FindHighestValue(String[] array)
        {
            // define return value
            String returnVal;

            // initialize to the first element in the array
            // (we must initialize to an array element)
            returnVal = array[0];

            // loop through the array
            foreach (String word in array)
            {
                // if the current value is greater than the saved highest value
                if (word.CompareTo(returnVal) > 0)
                {
                    // save this as the highest value
                    returnVal = word;
                }
            }

            // return the highest value
            return (returnVal);
        }


        // remove the first instance of a value from an array
        static void RemoveUnsortedValue(String removeValue, ref String[] array)
        {
            // allocate a new array to hold 1 less value than the source array
            String[] newArray = new String[array.Length - 1];

            // we need a separate counter to index into the new array, 
            // since we are skipping a value in the source array
            int dest = 0;

            // the same value may occur multiple times in the array, so skip subsequent occurrences
            bool bAlreadyRemoved = false;

            // iterate through the source array
            foreach (String word in array)
            {
                // if this is the word to be removed and we didn't remove it yet
                if (word.Equals(removeValue) && !bAlreadyRemoved)
                {
                    // set the flag that it was removed
                    bAlreadyRemoved = true;

                    // and skip it (ie. do not add it to the new array)
                    continue;
                }

                // insert the source word into the new array
                newArray[dest] = word;

                // increment the new array index to insert the next word
                ++dest;
            }

            // set the ref array equal to the new array, which has the target word removed
            // this changes the variable in the calling function (aUnsorted in this case)
            array = newArray;
        }
    }
}
