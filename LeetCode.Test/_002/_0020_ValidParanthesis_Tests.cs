using LeetCode._002;

namespace LeetCode.Test._002;

public class _0020_ValidParanthesis_Tests
{
    [TestCase("()", true)]
    [TestCase("()[]{}", true)]
    [TestCase("(]", false)]
    [TestCase("([)]", false)]
    [TestCase("{[]}", true)]
    [TestCase("", true)]
    [TestCase("(", false)]
    [TestCase(")", false)]
    public void IsValid_Test(string s, bool expected)
    {
        // Arrange
        _0020_ValidParanthesis solution = new ();

        // Act
        bool result = solution.IsValid(s);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
