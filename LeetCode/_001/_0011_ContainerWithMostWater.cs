namespace LeetCode._001;

public class _0011_ContainerWithMostWater
{
    public int MaxArea(int[] height)
    {
        int maxArea = 0;
        int left = 0;
        ReadOnlySpan<int> heights = new(height);
        int right = heights.Length - 1;
        while (left < right)
        {
            int width = right - left;
            int minHeight = Math.Min(heights[left], heights[right]);
            maxArea = Math.Max(maxArea, width * minHeight);
            if (heights[left] < heights[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }
        return maxArea;
    }
}
