namespace LeetCode._001;

public class _0018_FourSum
{
    public IList<IList<int>> FourSum(int[] nums, int target)
    {
        Span<int> numsS = new(nums);
        numsS.Sort(); // Sort the array in place
        ReadOnlySpan<int> sortedNums = numsS;
        return KSum(sortedNums, target, 0, 4);
    }

    public IList<IList<int>> KSum(ReadOnlySpan<int> nums, long target, int start, int k)
    {
        if (start == nums.Length)
        {
            return [];
        }

        long average = target / k;
        if (nums[start] > average || nums[^1] < average)
        {
            return [];
        }
        if (k == 2)
        {
            return TwoSum(nums, target, start);
        }

        List<IList<int>> result = [];
        for (int i = start; i < nums.Length; i++)
        {
            if (i > start && nums[i] == nums[i - 1])
            {
                continue;
            }

            IList<IList<int>> subResult = KSum(nums, target - nums[i], i + 1, k - 1);
            foreach (var subset in subResult)
            {
                subset.Insert(0, nums[i]);
            }

            result.AddRange(subResult);
        }
        return result;
    }

    public IList<IList<int>> TwoSum(ReadOnlySpan<int> nums, long target, int startIndex)
    {
        List<IList<int>> res = [];
        int lo = startIndex;
        int hi = nums.Length - 1;
        while (lo < hi)
        {
            int curr_sum = nums[lo] + nums[hi];
            if (curr_sum < target || (lo > startIndex && nums[lo] == nums[lo - 1]))
            {
                ++lo;
            }
            else if (curr_sum > target || (hi < nums.Length - 1 && nums[hi] == nums[hi + 1]))
            {
                --hi;
            }
            else
            {
                res.Add([nums[lo++], nums[hi--]]);
            }
        }

        return res;
    }
}
