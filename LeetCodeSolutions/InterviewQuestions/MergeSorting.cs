using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.InterviewQuestions
{
    public static class MergeSorting
    {
        //MergeSort(array, 0, array.Length - 1);
        public static void MergeSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                // Sol yarıyı sırala
                MergeSort(array, left, middle);

                // Sağ yarıyı sırala
                MergeSort(array, middle + 1, right);

                // İki yarıyı birleştir
                Merge(array, left, middle, right);
            }
        }

        public static void Merge(int[] array, int left, int middle, int right)
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;

            // Geçici diziler
            int[] LeftArray = new int[n1];
            int[] RightArray = new int[n2];

            // Sol ve sağ dizileri doldur
            for (int i = 0; i < n1; i++)
                LeftArray[i] = array[left + i];
            for (int j = 0; j < n2; j++)
                RightArray[j] = array[middle + 1 + j];

            // Sol ve sağ dizileri birleştir
            int k = left;
            int i1 = 0, j1 = 0;
            while (i1 < n1 && j1 < n2)
            {
                if (LeftArray[i1] <= RightArray[j1])
                {
                    array[k] = LeftArray[i1];
                    i1++;
                }
                else
                {
                    array[k] = RightArray[j1];
                    j1++;
                }
                k++;
            }

            // Kalan elemanları ekle
            while (i1 < n1)
            {
                array[k] = LeftArray[i1];
                i1++;
                k++;
            }

            while (j1 < n2)
            {
                array[k] = RightArray[j1];
                j1++;
                k++;
            }
        }
    }
}
