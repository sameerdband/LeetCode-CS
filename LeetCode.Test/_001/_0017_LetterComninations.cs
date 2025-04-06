using LeetCode._001;

namespace LeetCode.Test._001;

public class _0017_LetterComninations
{
    [TestCase("23", new[] { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" })]
    [TestCase("", new string[0])]
    [TestCase("2", new[] { "a", "b", "c" })]
    [TestCase(
        "234",
        new[]
        {
            "adg",
            "adh",
            "adi",
            "aeg",
            "aeh",
            "aei",
            "afg",
            "afh",
            "afi",
            "bdg",
            "bdh",
            "bdi",
            "beg",
            "beh",
            "bei",
            "bfg",
            "bfh",
            "bfi",
            "cdg",
            "cdh",
            "cdi",
            "ceg",
            "ceh",
            "cei",
            "cfg",
            "cfh",
            "cfi",
        }
    )]
    public void LetterCombinations_Test(string digits, string[] expected)
    {
        // Arrange
        var solution = new _0017_LetterCombinations();

        // Act
        var result = solution.LetterCombinations(digits);

        // Assert
        Assert.That(result, Is.EquivalentTo(expected));
    }
}
