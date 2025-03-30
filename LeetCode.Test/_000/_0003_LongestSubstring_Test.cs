using LeetCode._000;

namespace LeetCode.Test._000;

public class _0003_LongestSubstring_Test
{
    [TestCase("abcabcbb", 3)]
    [TestCase("abcabcbb", 3)]
    [TestCase("bbbbb", 1)]
    [TestCase("pwwkew", 3)]
    [TestCase("", 0)]
    [TestCase(" ", 1)]
    [TestCase("au", 2)]
    [TestCase("dvdf", 3)]
    [TestCase("aab", 2)]
    [TestCase("abcdef", 6)]
    [TestCase("abba", 2)]
    public void LengthOfLongestSubstring_Test(string input, int expected)
    {
        _0003_LongestSubstring solution = new();
        Assert.That(solution.LengthOfLongestSubstring(input), Is.EqualTo(expected));
    }
}
