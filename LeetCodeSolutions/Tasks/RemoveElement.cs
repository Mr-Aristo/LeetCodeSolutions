using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Tasks
{
    public static class RemoveElement //leetcode 27.
    {
        public static int ResultRemoveElement(int[] nums, int val)
        {
            if (nums.Length == 0)
                return 0;
            int count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[count] = nums[i];
                    count++;
                }
            }
            //   Array.Resize(ref nums, count);
            return count;
        }
    }
}
