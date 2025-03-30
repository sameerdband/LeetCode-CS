using LeetCode._001;

namespace LeetCode.Test._001;

public class _0011_ContainerWithMostWater_Test
{
    [TestCase(new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49)]
    [TestCase(new[] { 1, 1 }, 1)]
    [TestCase(new[] { 4, 3, 2, 1, 4 }, 16)]
    [TestCase(new[] { 1, 2, 1 }, 2)]
    [TestCase(new[] { 1, 2, 4, 3 }, 4)]
    public void MaxArea_Test(int[] height, int expected)
    {
        // Arrange
        var solution = new _0011_ContainerWithMostWater();

        // Act
        var result = solution.MaxArea(height);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
