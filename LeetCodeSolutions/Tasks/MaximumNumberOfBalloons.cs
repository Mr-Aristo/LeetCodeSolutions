using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Tasks
{
    public static class MaximumNumberOfBalloons
    {
        public static int MaxNumBaloons(string text) //1189 leetcode
        {
            string baloon = "baloon";

            HashSet<char> charSet = new HashSet<char>(baloon);

            int countChar = 0;

            foreach (var c in text)
            {
                if (charSet.Contains(c))
                {
                    if (charSet.SetEquals(text))
                    {
                        countChar++;
                    }
                }
            }
            return countChar;

        }
    }
}

