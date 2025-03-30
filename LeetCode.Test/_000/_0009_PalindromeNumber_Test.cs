using LeetCode._000;

namespace LeetCode.Test._000;

public class _0009_PalindromeNumber_Test
{
    [TestCase(121, true)]
    [TestCase(-121, false)]
    [TestCase(10, false)]
    [TestCase(0, true)]
    [TestCase(12321, true)]
    [TestCase(123321, true)]
    [TestCase(-101, false)] // Negative number with trailing zero
    public void IsPalindrome_Test(int x, bool expected)
    {
        // Arrange
        var solution = new _0009_PalindromeNumber();

        // Act
        var result = solution.IsPalindrome(x);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
