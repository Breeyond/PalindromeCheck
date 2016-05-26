using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PalindromeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to be reversed. We will then check to see if it is a Palindrome");
            string input = Console.ReadLine();
            string originalinput = input;

            input = input.ToLower();
            // Gathers input from the user. Before input is manipulated, sets it as the originalinput. Used when writing to the screen. 

            char[] inputArray = input.ToCharArray();
            //turns input into an array of characters. e.g.: Cat becomes  array cat = {c,a,t};
           //creates an array by turning the input the user types in, into an array of characters

            Regex rgx = new Regex("[^a-zA-Z0-9]");
            //regular expression that only accepts a-z, A-Z, and 0-9 - no punctuation

            input = rgx.Replace(input, "");
            
            Array.Reverse(inputArray);
            //reverses the input array

            
            //reverses the array of characters, aka reverses input

            string Reversal = String.Join("",inputArray);
            //combines the reversed character array. "t, a, c" becomes "tac"
            
            Reversal = rgx.Replace(Reversal,"");
            //a regular expression method from the regular expression library. It replaces non-alphanumeric characters with an empty string, thereby concatenaing the remaining characters into one long string. The new version is saved in.
             
            if (Reversal == input)
            {
                Console.WriteLine("");

                Console.WriteLine("Yes, '" + originalinput + "' is a palindrome!");
            }
            else
            {
                Console.WriteLine("No, " + originalinput + " is not  a palindrome!");
            } 




        }
    }
}
