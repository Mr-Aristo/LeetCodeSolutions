using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Tasks
{
    public static class NeedlString //leetcode 28.
    {
        public static int ResultString(string haystack, string needle) 
        {
            if (string.IsNullOrEmpty(needle))
            {
                return 0;
            }
            //indexof icinde buldugu ilk indexi dondurur aksi halde -1 doner.
            int index = haystack.IndexOf(needle);

            return index;
        }
    }
}
