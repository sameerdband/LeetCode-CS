using LeetCode._001;

namespace LeetCode.Test._001;

public class _0015_ThreeSum_Test
{
    private static readonly object[] TestCaseData =
    {
        new object[] { new[] { -1, 0, 1, 2, -1, -4 }, new int[][] { [-1, -1, 2], [-1, 0, 1] } },
        new object[] { new[] { 0, 1, 1 }, Array.Empty<int[]>() },
        new object[] { new[] { 0, 0, 0 }, new[] { new[] { 0, 0, 0 } } },
    };

    [TestCaseSource(nameof(TestCaseData))]
    public void ThreeSum_Test(int[] nums, int[][] expected)
    {
        // Arrange
        var solution = new _0015_ThreeSum();

        // Act
        var result = solution.ThreeSum(nums);

        // Assert
        Assert.That(result.Count, Is.EqualTo(expected.Length));
        foreach (var triplet in expected)
        {
            Assert.That(result.Any(r => r.SequenceEqual(triplet)), Is.True);
        }
    }
}
