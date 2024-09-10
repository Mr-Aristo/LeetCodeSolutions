using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Tasks
{
    public static class MiniMaxSum
    {

        /*
         * Given five positive integers, find the minimum and maximum values that can be calculated by
         * summing exactly four of the five integers. Then print the respective minimum and maximum values as a single 
         * line of two space-separated long integers.
         * Example arr = [1,2,3,5,7,9]
         * The minimum sum is 1+3+5+7=16
         * and the maximum sum is 3+5+7+9=24 
         * The function prints
         * 16 24
         */
        public static void minMax(List<int> arr)
        {
            arr.Sort();

            // En küçük 4 elemanın toplamı
            long minSum = arr.Take(4).Sum();

            // En büyük 4 elemanın toplamı
            long maxSum = arr.Skip(arr.Count - 4).Sum();

            // Sonuçları ekrana yazdırmak
            Console.WriteLine($"{minSum} {maxSum}");

            //int minSum = arr.Sum() - arr.Max();
            //int maxSum = arr.Sum() - arr.Min();

            //Console.WriteLine("{0} {1}", minSum, maxSum);


        }
    }
}
