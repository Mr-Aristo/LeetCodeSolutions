using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Tasks
{
    public static class TwoSum //leetcode 1.
    {
        public static int[] ResutTwoSum(int[] nums, int target)
        {
            Dictionary<int, int> numsToIndices = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (numsToIndices.ContainsKey(complement))
                {
                    return new int[] { numsToIndices[complement], i };
                }
                numsToIndices[nums[i]] = i;

            }
            return new int[] { };
        }
    }
}
