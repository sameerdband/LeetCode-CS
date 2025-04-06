namespace LeetCode._001;

public class _0016_ThreeSumClosest
{
    public int ThreeSumClosest(int[] nums, int target)
    {
        Span<int> numsSpan = nums.AsSpan();
        numsSpan.Sort(); // Sort the array in place
        ReadOnlySpan<int> sortedNums = numsSpan;
        int closestSum = sortedNums[0] + sortedNums[1] + sortedNums[2];

        for (int i = 0; i < sortedNums.Length - 2; i++)
        {
            int left = i + 1;
            int right = sortedNums.Length - 1;

            while (left < right)
            {
                int currentSum = sortedNums[i] + sortedNums[left] + sortedNums[right];

                if (Math.Abs(currentSum - target) < Math.Abs(closestSum - target))
                {
                    closestSum = currentSum;
                }

                if (currentSum < target)
                {
                    left++;
                }
                else if (currentSum > target)
                {
                    right--;
                }
                else
                {
                    return currentSum; // Exact match found
                }
            }
        }

        return closestSum;
    }
}
