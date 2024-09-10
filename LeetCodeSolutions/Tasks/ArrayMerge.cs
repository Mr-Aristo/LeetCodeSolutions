using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Tasks
{
    public static class ArrayMerge
    {
        public static void Merging(int[] arr1, int[] arr2)
        {
            int[] mergedArray = new int[arr1.Length + arr2.Length];

            for (int i = 0; i < arr1.Length; i++)
            {
                mergedArray[i] = arr1[i];

            }

            for (int j = 0; j < arr2.Length; j++)
            {
                mergedArray[arr1.Length + j] = arr1[j];

            }

            foreach (var item in mergedArray)
            {
                Console.Write(item + ",");
            }

        }
    }
}
