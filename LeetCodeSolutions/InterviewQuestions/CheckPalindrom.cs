using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.InterviewQuestions
{
    public static class CheckPalindrom
    {

        public static void PolindromChecker(string str)
        {
            bool flag = false;

            for (int i = 0, j = str.Length - 1; i < str.Length / 2; i++, j--)
            {

                if (str[i] != str[j])
                {
                    flag = false;
                    break;
                }
                else
                {
                    flag = true;
                }


            }
            if (flag)
            {
                Console.WriteLine("Palindrom");
            }
            else
            {
                Console.WriteLine("Not Palindrom");
            }

        }
    }
}
