using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.InterviewQuestions
{
    public static class ReverseString
    {
        public static void Reverse(string str)
        {
            char[] chars = str.ToCharArray();

            for (int i = 0 , j = str.Length-1; i<j;i++,j--)
            {
                chars[i] = str[j];
                chars[j] = str[i];
            }

            string reversedstring = new string(chars);

            Console.WriteLine(reversedstring);

        }
    }
}
