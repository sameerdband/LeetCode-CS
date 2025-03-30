namespace LeetCode._001;

public class _0014_LongestCommonPrefix
{
    public string LongestCommonPrefix(string[] strs)
    {
        ReadOnlySpan<string> input = strs.AsSpan();
        if (input.Length == 0)
            return string.Empty;
        if (input.Length == 1)
            return input[0];
        int minLength = int.MaxValue;
        foreach (string str in input)
        {
            if (str.Length < minLength)
            {
                minLength = str.Length;
            }
        }
        Span<char> prefix = stackalloc char[minLength];
        for (int i = 0; i < minLength; i++)
        {
            char currentChar = input[0][i];
            for (int j = 1; j < input.Length; j++)
            {
                if (input[j][i] != currentChar)
                {
                    return new string(prefix[..i]);
                }
            }
            prefix[i] = currentChar;
        }
        return new string(prefix[..minLength]);
    }
}
