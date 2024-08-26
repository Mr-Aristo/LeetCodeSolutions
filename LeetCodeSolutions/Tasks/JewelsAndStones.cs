using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Tasks
{
    /*You're given strings jewels representing the types of stones that are jewels, 
     * and stones representing the stones you have. Each character in stones is a type of stone you have.
     * You want to know how many of the stones you have are also jewels.
     * Letters are case sensitive, so "a" is considered a different type of stone from "A".
     */

    //Input: jewels = "aA", stones = "aAAbbbb"
    //Output: 3
    public static class JewelsAndStones
    {
        public static int NumJewlesInStones(string jewels, string stones)
        {
            HashSet<char> jewelSet = new HashSet<char>(jewels);
            int jewelsCount = 0;

            

            foreach (var item in stones)
            {
                if (jewelSet.Contains(item))
                {
                    jewelsCount++;

                }

            }

            return jewelsCount;

        }
    }
}
