namespace LeetCode._001;

public class _0015_ThreeSum
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        if (nums.Length < 3)
        {
            return []; // Not enough numbers to form a triplet
        }
        Span<int> numsSpan = nums.AsSpan();
        numsSpan.Sort(); // Sort the array in place
        ReadOnlySpan<int> sortedNums = numsSpan;
        List<IList<int>> result = [];

        for (int i = 0; i < sortedNums.Length - 2; i++)
        {
            // Skip duplicates for the first number
            if (i > 0 && sortedNums[i] == sortedNums[i - 1])
            {
                continue;
            }

            int left = i + 1;
            int right = sortedNums.Length - 1;

            while (left < right)
            {
                int sum = sortedNums[i] + sortedNums[left] + sortedNums[right];

                if (sum == 0)
                {
                    result.Add(
                        new List<int> { sortedNums[i], sortedNums[left], sortedNums[right] }
                    );

                    // Skip duplicates for the second and third numbers
                    while (left < right && sortedNums[left] == sortedNums[left + 1])
                        left++;
                    while (left < right && sortedNums[right] == sortedNums[right - 1])
                        right--;

                    left++;
                    right--;
                }
                else if (sum < 0)
                {
                    left++; // Move the left pointer to increase the sum
                }
                else
                {
                    right--; // Move the right pointer to decrease the sum
                }
            }
        }

        return result;
    }
}
