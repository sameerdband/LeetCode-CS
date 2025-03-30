using LeetCode._000;

namespace LeetCode.Test._000;

public class _0005_LongestPalindrome_Test
{
    [TestCase("abcabcbabcaba", "abcba")]
    //[TestCase("babad", "bab")]
    //[TestCase("cbbd", "bb")]
    //[TestCase("a", "a")]
    //[TestCase("ac", "a")]
    public void LongestPalindrome_Test(string s, string expected)
    {
        // Arrange
        var solution = new _0005_LongestPalindrome();

        // Act
        var result = solution.LongestPalindrome(s);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
