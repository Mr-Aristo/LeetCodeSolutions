using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Tasks
{
    public static class SearcInsert //leetcode 35.
    {
        public static int ResulrSearchInsert(int[] arr, int target)
        {//Binary serch 

            int left = 0;
            int right = arr.Length;
            if (arr[right - 1] < target)
            {
                return right;
            }
            if (arr[left] > target)
            {
                return 0;
            }
            int mid = (int)(right + left) / 2;
            while (left <= right)
            {
                if (arr[mid] > target)
                {
                    right = mid - 1;
                }
                else if (arr[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    return mid;
                }
                mid = (int)(right + left) / 2;
            }

            return left;
        }
    }
}
