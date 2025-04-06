using LeetCode._036;

namespace LeetCode.Test._036;

public class _0368_LargestDivisibleSubset_Tests
{
    [TestCase(new[] { 1, 2, 3 }, new[] { 1, 2 })]
    [TestCase(new[] { 1, 2, 4, 8 }, new[] { 1, 2, 4, 8 })]
    [TestCase(new[] { 3, 4, 16, 8 }, new[] { 4, 8, 16 })] // Non-sorted input
    [TestCase(new[] { 1 }, new[] { 1 })] // Single element
    [TestCase(new[] { 1, 2, 3, 6 }, new[] { 1, 2, 6 })] // Multiple valid subsets
    [TestCase(new[] { 2, 3, 5, 7 }, new[] { 3 })] // No divisible pairs
    [TestCase(new int[] { }, new int[] { })] // Empty input
    [TestCase(new[] { 1, 1, 1 }, new[] { 1, 1, 1 })] // All elements are the same
    [TestCase(new[] { 1, 2, 4, 8, 16, 32 }, new[] { 1, 2, 4, 8, 16, 32 })] // Large subset
    [TestCase(new[] { 100, 50, 25, 5, 1 }, new[] { 1, 5, 25, 50, 100 })] // Descending order input
    public void LargestDivisibleSubset_Test(int[] input, int[] expected)
    {
        // Arrange
        var solution = new _0368_LargestDivisibleSubset();

        // Act
        var actual = solution.LargestDivisibleSubset(input);

        // Assert
        Assert.That(actual, Is.EquivalentTo(expected));
    }
}
