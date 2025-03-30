namespace LeetCode._000;

public class _0001_TwoSum
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = [];
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (map.TryGetValue(complement, out int value))
            {
                return [value, i];
            }
            map[nums[i]] = i;
        }

        return [];
    }
}
