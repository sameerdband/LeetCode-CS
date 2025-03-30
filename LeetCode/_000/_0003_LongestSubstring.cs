namespace LeetCode._000;

public class _0003_LongestSubstring
{
    public int LengthOfLongestSubstring(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return 0;
        }

        ReadOnlySpan<char> sSpan = s;

        int n = sSpan.Length;
        int maxLength = 0;
        int left = 0;
        Dictionary<char, int> charIndexMap = [];

        for (int right = 0; right < n; right++)
        {
            if (charIndexMap.TryGetValue(sSpan[right], out int value))
            {
                left = Math.Max(value + 1, left);
            }

            charIndexMap[sSpan[right]] = right;
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}
