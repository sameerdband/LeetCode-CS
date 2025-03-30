namespace LeetCode._000;

public class _0005_LongestPalindrome
{
    public string LongestPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return s;
        }

        Span<char> sprimeSpan = new char[s.Length * 2 + 1];
        sprimeSpan[0] = '|';
        for (int i = 0; i < s.Length; i++)
        {
            sprimeSpan[2 * i + 1] = s[i];
            sprimeSpan[2 * i + 2] = '|';
        }
        ReadOnlySpan<char> sprime = sprimeSpan;
        Span<int> p = new int[sprime.Length];
        int center = 0;
        int right = 0;
        int maxLength = 0;
        int centerIndex = 0;

        for (int i = 1; i < sprime.Length; i++)
        {
            int mirror = 2 * center - i;
            if (i < right)
            {
                p[i] = Math.Min(right - i, p[mirror]);
            }

            while (
                i + p[i] + 1 < sprime.Length
                && i - p[i] - 1 >= 0
                && sprime[i + p[i] + 1] == sprime[i - p[i] - 1]
            )
            {
                p[i]++;
            }

            if (i + p[i] > right)
            {
                center = i;
                right = i + p[i];
            }
        }

        for (int i = 1; i < p.Length; i++)
        {
            if (p[i] > maxLength)
            {
                maxLength = p[i];
                centerIndex = i;
            }
        }
        int start = (centerIndex - maxLength) / 2;
        int end = start + maxLength - 1;
        return s.Substring(start, end - start + 1);
    }
}
