using LeetCode._001;

namespace LeetCode.Test._001;

public class _0013_RomanToInteger_Test
{
    [TestCase("III", 3)]
    [TestCase("IV", 4)]
    [TestCase("IX", 9)]
    [TestCase("LVIII", 58)]
    [TestCase("MCMXCIV", 1994)]
    public void RomanToInt_Test(string s, int expected)
    {
        // Arrange
        var solution = new _0013_RomanToInteger();

        // Act
        var result = solution.RomanToInt(s);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
