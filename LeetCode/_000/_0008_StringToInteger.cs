namespace LeetCode._000;

public class _0008_StringToInteger
{
    public int MyAtoi(string s)
    {
        ReadOnlySpan<char> sSpan = s.AsSpan().TrimStart();
        if (sSpan.IsEmpty)
            return 0;

        bool sign = false;
        int startIndex = 0;
        if (sSpan[0] == '-')
        {
            sign = true;
            startIndex++;
        }
        else if (sSpan[0] == '+')
        {
            startIndex++;
        }

        int result = 0;
        int positiveOverflow = int.MaxValue / 10;
        for (int i = startIndex; i < sSpan.Length; i++)
        {
            if (sSpan[i] < '0' || sSpan[i] > '9')
            {
                break;
            }

            int digit = sSpan[i] - '0';
            if (result > positiveOverflow || (result == positiveOverflow && digit > 7))
            {
                return sign ? int.MinValue : int.MaxValue; // Overflow occurred
            }

            result = result * 10 + digit;
        }

        return sign ? -result : result;
    }
}
