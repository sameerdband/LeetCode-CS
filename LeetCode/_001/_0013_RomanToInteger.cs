namespace LeetCode._001;

public class _0013_RomanToInteger
{
    public int RomanToInt(string s)
    {
        ReadOnlySpan<char> input = s.AsSpan();
        int result = 0;
        int prevValue = 0;

        for (int i = input.Length - 1; i >= 0; i--)
        {
            int value = input[i] switch
            {
                'I' => 1,
                'V' => 5,
                'X' => 10,
                'L' => 50,
                'C' => 100,
                'D' => 500,
                'M' => 1000,
                _ => throw new ArgumentOutOfRangeException(
                    nameof(input),
                    $"Invalid Roman numeral: {input[i]}"
                ),
            };
            if (value < prevValue)
            {
                result -= value;
            }
            else
            {
                result += value;
            }
            prevValue = value;
        }

        return result;
    }
}
