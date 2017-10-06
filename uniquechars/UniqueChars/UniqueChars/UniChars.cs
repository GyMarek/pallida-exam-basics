using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueChars
{
    public class UniChars
    {
        // Create a method called `UniqueCharacters` that takes a string as parameter
        // and returns a list with the unique letters of the given string
        // Create basic unit tests for it with at least 3 different test cases
        // Print the characters from that list in the following format:
        // "n", "g", "r", "m"


        public char[] UniqueCharacters(string input)
        {
            input = input.Replace(" ", String.Empty);
            char[] uniqueChars = input.ToCharArray();
            return uniqueChars;
        }
    }
}
