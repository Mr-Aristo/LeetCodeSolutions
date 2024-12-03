using LeetCodeSolutions.InterviewQuestions;
using LeetCodeSolutions.Search;
using LeetCodeSolutions.Sorting.Insertion;
using LeetCodeSolutions.SortingAlgorithms.Merge;
using LeetCodeSolutions.Tasks;

namespace LeetCodeSolutions
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<int> list = [ 8, 3, 5, 1, 4, 7, 6, 2 ];

         // MergeSorting.MergeSort(list, 0, list.Length-1);
            //BinarySearch binarySearch = new BinarySearch();

            //  int[] sortedArray = { 1, 3, 5, 7, 9, 11, 13, 15 };
            //  int target = 15;
            List<int> array = [2,4,6,8,3];

            InsertionSort.SortFromTheEnd();
                                                
         
            
        }






        #region MultipleReturn
        public static (int count, int[] result) MultipleReturn(int[] nums, int val)
        {
            if (nums.Length == 0)
            {
                return (0, new int[0]);
            }

            int count = 0;
            int[] result = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    result[count] = nums[i];
                    count++;
                }
            }

            Array.Resize(ref result, count);
            return (count, result);
        }
        #endregion
    }
}

