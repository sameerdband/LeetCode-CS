namespace LeetCode._001;

public class _0017_LetterCombinations
{
    private static readonly string[] Mappings =
    [
        "", // 0
        "", // 1
        "abc", // 2
        "def", // 3
        "ghi", // 4
        "jkl", // 5
        "mno", // 6
        "pqrs", // 7
        "tuv", // 8
        "wxyz", // 9
    ];

    public IList<string> LetterCombinations(string digits)
    {
        ReadOnlySpan<char> digitsSpan = digits.AsSpan();
        if (digitsSpan.Length == 0)
            return Array.Empty<string>();

        List<string> result = [];
        Span<char> currentCombination = stackalloc char[digitsSpan.Length];
        GenerateCombinations(digitsSpan, 0, currentCombination, result);
        return result;
    }

    private void GenerateCombinations(
        ReadOnlySpan<char> digits,
        int index,
        Span<char> currentCombination,
        List<string> result
    )
    {
        if (index == digits.Length)
        {
            result.Add(new string(currentCombination[..index]));
            return;
        }

        int digit = digits[index] - '0';
        ReadOnlySpan<char> letters = Mappings[digit].AsSpan();

        foreach (char letter in letters)
        {
            currentCombination[index] = letter;
            GenerateCombinations(digits, index + 1, currentCombination, result);
        }
    }
}
