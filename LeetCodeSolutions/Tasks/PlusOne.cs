using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Tasks
{
    public static class PlusOne
    {
        public static int[] ResultPlusOne(int[] digits)
        {// example Input: digits = [1,2,3]  Output: [1, 2, 4]

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                int digit = digits[i];

                // If num is less than 9 simply increment
                if (digit < 9)
                {
                    digits[i] = digit + 1;
                    return digits;
                }
                else
                {
                    // Set current num to 0 and there will be a carry.
                    digits[i] = 0;
                }
            }

            // Edge case when all values are 9's
            int[] newDigitArray = new int[digits.Length + 1];
            newDigitArray[0] = 1;

            return newDigitArray;
        }
    }
}
