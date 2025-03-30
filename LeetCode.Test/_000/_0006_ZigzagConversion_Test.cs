using LeetCode._000;

namespace LeetCode.Test._000;

public class _0006_ZigzagConversion_Test
{
    [TestCase("0123456789ABCDEF", 3, "048C13579BDF26AE")]
    [TestCase("0123456789ABCDEF", 4, "06C157BD248AE39F")]
    [TestCase("0123456789ABCDEF", 5, "08179F26AE35BD4C")]
    [TestCase("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
    [TestCase("PAYPALISHIRING", 4, "PINALSIGYAHRPI")]
    [TestCase("A", 1, "A")]
    [TestCase("AB", 1, "AB")]
    public void Convert_Test(string s, int numRows, string expected)
    {
        // Arrange
        var solution = new _0006_ZigzagConversion();

        // Act
        var result = solution.Convert(s, numRows);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
