using LeetCode._000;

namespace LeetCode.Test._000;

public class _0007_ReverseInteger_Test
{
    [TestCase(123, 321)]
    [TestCase(-123, -321)]
    [TestCase(120, 21)]
    [TestCase(0, 0)]
    [TestCase(1534236469, 0)] // Overflow case
    public void Reverse_Test(int x, int expected)
    {
        // Arrange
        var solution = new _0007_ReverseInteger();

        // Act
        var result = solution.Reverse(x);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
