using LeetCode._001;

namespace LeetCode.Test._001;

public class _0014_LongestCommonPrefix_Test
{
    [TestCase(new[] { "flower", "flow", "flight" }, "fl")]
    [TestCase(new[] { "dog", "racecar", "car" }, "")]
    [TestCase(new[] { "a" }, "a")]
    [TestCase(new[] { "" }, "")]
    [TestCase(new[] { "ab", "a" }, "a")]
    public void LongestCommonPrefix_Test(string[] strs, string expected)
    {
        // Arrange
        var solution = new _0014_LongestCommonPrefix();

        // Act
        var result = solution.LongestCommonPrefix(strs);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
