using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputChallengesConsole
{
    public static class StringHelper
    {
        public static string RemoveNonLetters(string inputString)
        {
            List<char> letterChars = new List<char>();

            foreach (var c in inputString.ToCharArray())
            {
                if (Char.IsLetter(c))
                {
                    letterChars.Add(c);
                }
            }

            return new string(letterChars.ToArray());
        }
    }
}
