using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueChars
{
    public class UniChars
    {
        public char[] UniqueCharacters(string input, int maxRepeat)
        {
            if (input.Length == 0)
            {
                return input;
            } 

            StringBuilder b = new StringBuilder;
            Char[] chars = input.ToCharArray();
            Char lastChar = chars[0];
            int repeat = 0;
            for (int i = 1; i < input.Length; i++)
            {
                if (chars[i] == lastChar && ++repeat < maxRepeat)
                {
                    b.Append(chars[i]);
                }
                else
                {
                    b.Append(chars[i]);
                    repeat = 0;
                    lastChar = chars[i];
                }
            }
            return b.ToString();
        }
    }
}
