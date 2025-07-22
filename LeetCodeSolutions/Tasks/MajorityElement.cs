namespace LeetCodeSolutions.Tasks;
public static class MajorityElement
{
    public static int FindMajority(int[] nums)
    {
        int t = 1;

        Dictionary<int, int> elements = new Dictionary<int, int>();

        foreach (int xkey in nums)
        {
            if (elements.ContainsKey(xkey))
            {
                elements[xkey] += 1;
            }
            else
            {
                elements.Add(xkey, 1);
            }

        }

        var majorityElement = elements.Aggregate((l, r) => l.Value > r.Value ? l : r);


        return majorityElement.Key;
    }
}

/*

Given an array nums of size n, return the majority element.
The majority element is the element that appears more than ⌊n / 2⌋ times. You may assume that the majority element always exists in the array.

Example 1:
Input: nums = [3,2,3]
Output: 3

Example 2:
Input: nums = [2,2,1,1,1,2,2]
Output: 2

 */