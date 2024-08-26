using LeetCodeSolutions.Tasks;

namespace LeetCodeSolutions
{
    public class Program
    {
        static void Main(string[] args)
        {

            //int[] arr = { 4, 4, 2, 3, 4, 4 };
            //int[] arr2 = { 2, 7, 11, 15 };
            //int target = 9;
            //string tr = "123";
            //string ms = "SAD123";

            //Console.WriteLine(ms.IndexOf(tr));

            //int[] arr = { 1, 2, 3, 4, 5, 6 };
            //int target = 3;
            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            //Console.WriteLine(SearchInser(arr, target));
            //sw.Stop();
            // Console.WriteLine(sw.Elapsed);

            //int k = RemoveDuplicates(arr);
            //int k = RemoveElement(arr,4);

            //int[] result = TwoSum(arr2, target);
            //Console.WriteLine("Indices of the two numbers that add up to the target are: [{0}, {1}]", result[0], result[1]);

            //Console.WriteLine("k = " + k); // Output: k = 5
            ////Console.WriteLine("Modified array:");

            //for (int i = 0; i < k; i++)
            //{
            //    Console.Write(arr[i] + " "); // Output: 0 1 2 3 4 
            //}
            //int[] arr = { 1, 2, 3, 4, 9 };

            //foreach (var item in PlusOne(arr))
            //{
            //    Console.Write(item);
            //}
            string s = "anagram";
            string text = "nlaebolko";


            //var res = JewelsAndStones.NumJewlesInStones(j, s);
            var res = MaximumNumberOfBalloons.MaxNumBaloons(text);
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

