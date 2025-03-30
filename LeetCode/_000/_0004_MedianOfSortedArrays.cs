namespace LeetCode._000;

public class _0004_MedianOfSortedArrays
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        if (nums1.Length > nums2.Length)
        {
            (nums1, nums2) = (nums2, nums1);
        }

        ReadOnlySpan<int> nums1Span = nums1;
        ReadOnlySpan<int> nums2Span = nums2;
        int length1 = nums1Span.Length;
        int length2 = nums2Span.Length;
        int start = 0;
        int end = length1;

        while (start <= end)
        {
            int part1 = (start + end) / 2;
            int part2 = (length1 + length2 + 1) / 2 - part1;

            int max1 = part1 == 0 ? int.MinValue : nums1[part1 - 1];
            int min1 = part1 == length1 ? int.MaxValue : nums1[part1];

            int max2 = part2 == 0 ? int.MinValue : nums2[part2 - 1];
            int min2 = part2 == length2 ? int.MaxValue : nums2[part2];

            if (max1 <= min2 && min1 >= max2)
            {
                if ((length1 + length2) % 2 == 0)
                {
                    return (Math.Max(max1, max2) + Math.Min(min1, min2)) / 2.0;
                }
                return Math.Max(max1, max2);
            }
            else if (max1 > min2)
            {
                end = part1 - 1;
            }
            else
            {
                start = part1 + 1;
            }
        }

        return 0.0; // This line should never be reached if the input arrays are valid
    }
}
