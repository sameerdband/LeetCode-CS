using LeetCode._001;

namespace LeetCode.Test._001;

public class _0012_IntegerToRoman_Test
{
    [TestCase(3, "III")]
    [TestCase(4, "IV")]
    [TestCase(9, "IX")]
    [TestCase(58, "LVIII")]
    [TestCase(1994, "MCMXCIV")]
    public void IntToRoman_Test(int num, string expected)
    {
        // Arrange
        var solution = new _0012_IntegerToRoman();

        // Act
        var result = solution.IntToRoman(num);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
