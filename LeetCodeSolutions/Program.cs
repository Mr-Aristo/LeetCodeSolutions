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
            int[] arr = { 1, 2, 3, 4, 9 };

            foreach (var item in PlusOne(arr))
            {
                Console.Write(item);
            }

        }
        public static int[] PlusOne(int[] digits)
        {// example Input: digits = [1,2,3]  Output: [1, 2, 4]

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                int digit = digits[i];

                // If num is less than 9 simply increment
                if (digit < 9)
                {
                    digits[i] = digit + 1;
                    return digits;
                }
                else
                {
                    // Set current num to 0 and there will be a carry.
                    digits[i] = 0;
                }
            }

            // Edge case when all values are 9's
            int[] newDigitArray = new int[digits.Length + 1];
            newDigitArray[0] = 1;

            return newDigitArray;
        }

        #region LengthOfLastWord
        public static int LengthOfLastWord(string s)
        {//example Input: s = "   fly me   to   the moon  "
            List<String> mylist = s.Trim().Split(" ").ToList();
            int i = mylist.Count() - 1;
            var myword = mylist[i];
            int mycount = myword.Length;
            return mycount;
            //Trim() stringin basindaki ve sonundaki bosluklari siler. 
            //Split ile de kelimeleri ayri ayri aliriz. arada bosluk odugus surece
        }
        #endregion

        #region SearcInsert
        public static int SearchInser(int[] arr, int target)//leetcode 35.
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
        #endregion

        #region Find needlString leetcode28

        public static int StrStr(string haystack, string needle) //leetcode 28.
        {
            if (string.IsNullOrEmpty(needle))
            {
                return 0;
            }
            //indexof icinde buldgi ilk indexi dondurur aksi halde -1 doner.
            int index = haystack.IndexOf(needle);

            return index;
        }
        #endregion

        #region TwoSum
        public static int[] TwoSum(int[] nums, int target)//leetcode 1.
        {
            Dictionary<int, int> numsToIndices = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (numsToIndices.ContainsKey(complement))
                {
                    return new int[] { numsToIndices[complement], i };
                }
                numsToIndices[nums[i]] = i;

            }
            return new int[] { };
        }
        #endregion

        #region RemoveDublicates
        public static int RemoveDuplicates(int[] nums)//leetcode 26.
        {
            if (nums.Length == 0)
                return 0;
            int uniqueIndex = 1;
            int[] result = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    nums[uniqueIndex] = nums[i];
                    uniqueIndex++;
                }
            }
            return uniqueIndex;
        }
        #endregion

        #region RemoveElement
        public static int RemoveElement(int[] nums, int val)//leetcode 27.
        {
            if (nums.Length == 0)
                return 0;
            int count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[count] = nums[i];
                    count++;
                }
            }
            //   Array.Resize(ref nums, count);
            return count;
        }
        #endregion

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

