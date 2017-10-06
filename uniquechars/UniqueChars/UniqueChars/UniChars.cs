using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueChars
{
    public class UniChars
    {
        public char[] UniqueCharacters(string input)
        {
            input = input.Replace(" ", String.Empty).ToLower();
            char[] uniqueChar= input.ToCharArray();
            Array.Sort(uniqueChar);

            for (int i = 0; i < uniqueChar.Length; i++)
            {
                if (i == i + 1)
                {
                    uniqueChar.ElementAt(i);
                    uniqueChar.ElementAt(i + 1);
                }
            }
            return uniqueChar;
        }
    }
}
