namespace LeetCode._000;

public class _0006_ZigzagConversion
{
    public string Convert(string s, int numRows)
    {
        if (numRows == 1 || numRows >= s.Length)
        {
            return s;
        }

        ReadOnlySpan<char> input = s.AsSpan();
        Span<char> result = new char[input.Length];
        int index = 0;
        int cycleLength = 2 * numRows - 2;

        for (int j = 0; j < input.Length; j += cycleLength)
        {
            result[index++] = input[j];
        }

        for (int row = 1; row < numRows - 1; row++)
        {
            for (int j = 0; j + row < input.Length; j += cycleLength)
            {
                result[index++] = input[j + row];
                if (j + cycleLength - row < input.Length)
                {
                    result[index++] = input[j + cycleLength - row];
                }
            }
        }

        for (int j = numRows - 1; j < input.Length; j += cycleLength)
        {
            result[index++] = input[j];
        }

        return new string(result);
    }
}
