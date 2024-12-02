using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.SortingAlgorithms.Merge
{
    public static class MergeSort
    {
        //List<int> list = new List<int> { 38, 27, 43, 3, 9, 82, 10 };
        //Sort(list, 0, list.Count - 1);

        public static void Sort(List<int> list, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                Sort(list, left, middle);

                Sort(list, middle + 1, right);

                Merge(list, left, middle, right);
            }
        }

        public static void Merge(List<int> list, int left, int middle, int right)
        {
            int leftSize = middle - left + 1;
            int rightSize = right - middle;

            List<int> leftList = new List<int>(leftSize);
            List<int> rightList = new List<int>(rightSize);

            for (int i = 0; i < leftSize; i++)
                leftList.Add(list[left + i]);

            for (int j = 0; j < rightSize; j++)
                rightList.Add(list[middle + 1 + j]);

            int leftIndex = 0, rightIndex = 0;
            int mainIndex = left;

            while (leftIndex < leftSize && rightIndex < rightSize)
            {
                if (leftList[leftIndex] <= rightList[rightIndex])
                {
                    list[mainIndex] = leftList[leftIndex];
                    leftIndex++;
                }
                else
                {
                    list[mainIndex] = rightList[rightIndex];
                    rightIndex++;
                }
                mainIndex++;
            }

            while (leftIndex < leftSize)
            {
                list[mainIndex] = leftList[leftIndex];
                leftIndex++;
                mainIndex++;
            }

            while (rightIndex < rightSize)
            {
                list[mainIndex] = rightList[rightIndex];
                rightIndex++;
                mainIndex++;
            }
        }

    }
}
