using LeetCode._000;

namespace LeetCode.Test._000;

public class _0008_StringToInteger_Test
{
    [TestCase("42", 42)]
    [TestCase("   -42", -42)]
    [TestCase("4193 with words", 4193)]
    [TestCase("words and 987", 0)]
    [TestCase("-91283472332", -2147483648)] // Overflow case
    [TestCase("91283472332", 2147483647)] // Overflow case
    public void MyAtoi_Test(string s, int expected)
    {
        // Arrange
        var solution = new _0008_StringToInteger();

        // Act
        var result = solution.MyAtoi(s);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
