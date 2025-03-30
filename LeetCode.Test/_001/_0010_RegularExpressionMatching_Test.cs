using LeetCode._001;

namespace LeetCode.Test._001;

public class _0010_RegularExpressionMatching_Test
{
    [TestCase("aa", "a", false)]
    [TestCase("aa", "a*", true)]
    [TestCase("ab", ".*", true)]
    [TestCase("aab", "c*a*b", true)]
    [TestCase("mississippi", "mis*is*p*.", false)]
    [TestCase("ab", ".*c", false)]
    [TestCase("a", ".*", true)]
    [TestCase("a", "a*", true)]
    public void IsMatch_Test(string s, string p, bool expected)
    {
        // Arrange
        var solution = new _0010_RegulaExpressionMatching();

        // Act
        var result = solution.IsMatch(s, p);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
