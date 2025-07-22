using LeetCodeSolutions.InterviewQuestions;
using LeetCodeSolutions.Search;
using LeetCodeSolutions.Sorting.Insertion;
using LeetCodeSolutions.SortingAlgorithms.Merge;
using LeetCodeSolutions.String;
using LeetCodeSolutions.Tasks;

namespace LeetCodeSolutions
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<int> list = [8, 3, 5, 1, 4, 7, 6, 2];

            int[] array = [2, 2, 1, 1, 1, 2, 2];

            var res = MajorityElement.FindMajority(array);

            Console.WriteLine(res);

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

