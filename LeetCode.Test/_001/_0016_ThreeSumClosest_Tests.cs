using LeetCode._001;

namespace LeetCode.Test._001;

public class _0016_ThreeSumClosest_Tests
{
    [TestCase(new[] { -1, 2, 1, -4 }, 1, 2)]
    [TestCase(new[] { 0, 0, 0 }, 1, 0)]
    [TestCase(new[] { -4, -1, 1, 2 }, 1, 2)]
    [TestCase(new[] { -1, 0, 1, 1 }, 0, 0)]
    public void ThreeSumClosest_Test(int[] nums, int target, int expected)
    {
        // Arrange
        var solution = new _0016_ThreeSumClosest();

        // Act
        var result = solution.ThreeSumClosest(nums, target);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
