using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Tasks
{
    public static class Dublicates 
    {
        public static int RemoveDuplicates(int[] nums)//leetcode 26.
        {
            if (nums.Length == 0)
                return 0;
            int uniqueIndex = 1;
            int[] result = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    nums[uniqueIndex] = nums[i];
                    uniqueIndex++;
                }
            }
            return uniqueIndex;
        }

        //Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
        //Input: nums = [1, 2, 3, 1]
        //Output: true
        public static bool ContainsDublicate(int[] nums) //217. Contains Dublicate 
        {            
            HashSet<int> seenNumbers = new HashSet<int>();

        
            foreach (int num in nums)
            {
            
                if (!seenNumbers.Add(num))
                {
                    return true;
                }
            }

         
            return false;
        }

    }
}
