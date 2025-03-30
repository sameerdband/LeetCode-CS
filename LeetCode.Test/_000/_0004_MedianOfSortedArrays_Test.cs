using LeetCode._000;

namespace LeetCode.Test._000;

public class _0004_MedianOfSortedArrays_Test
{
    [TestCase(new[] { 1, 3 }, new[] { 2 }, 2.0)]
    [TestCase(new[] { 1, 2 }, new[] { 3, 4 }, 2.5)]
    [TestCase(new[] { 0, 0 }, new[] { 0, 0 }, 0.0)]
    [TestCase(new int[0] { }, new[] { 1 }, 1.0)]
    [TestCase(new[] { 2 }, new int[0], 2.0)]
    public void FindMedianSortedArrays_Test(int[] nums1, int[] nums2, double expected)
    {
        _0004_MedianOfSortedArrays solution = new();
        Assert.That(solution.FindMedianSortedArrays(nums1, nums2), Is.EqualTo(expected));
    }
}
