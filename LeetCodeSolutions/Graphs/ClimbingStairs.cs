using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Graphs
{
    public static class ClimbingStairs
    {
        public static int Climb(int n)
        {
            if (n <= 2) return n;

            int prev = 1, curr = 2;

            for (int i = 3; i <= n; i++) 
            { 
                int temp = curr;

                curr = prev + curr; // Fibonacci mantığı: dp[n] = dp[n-1] + dp[n-2]

                prev = temp;
            }

            return curr;
        }
    }
}


/*
 
You are climbing a staircase. It takes n steps to reach the top.
Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?

Example 1:

Input: n = 2
Output: 2
Explanation: There are two ways to climb to the top.
1. 1 step + 1 step
2. 2 steps

*/