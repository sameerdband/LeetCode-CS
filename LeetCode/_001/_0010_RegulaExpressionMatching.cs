namespace LeetCode._001;

public class _0010_RegulaExpressionMatching
{
    public bool IsMatch(string s, string p)
    {
        if (string.IsNullOrEmpty(p))
        {
            return string.IsNullOrEmpty(s);
        }
        ReadOnlySpan<char> str = s.AsSpan();
        ReadOnlySpan<char> ptr = p.AsSpan();

        bool[,] resultTable = new bool[str.Length + 1, ptr.Length + 1];

        resultTable[str.Length, ptr.Length] = true;
        for (int i = str.Length; i >= 0; i--)
        {
            for (int j = ptr.Length - 1; j >= 0; j--)
            {
                bool match = i < str.Length && (str[i] == ptr[j] || ptr[j] == '.');
                if (j + 1 < ptr.Length && ptr[j + 1] == '*')
                {
                    resultTable[i, j] = resultTable[i, j + 2] || (match && resultTable[i + 1, j]);
                }
                else
                {
                    resultTable[i, j] = match && resultTable[i + 1, j + 1];
                }
            }
        }

        return resultTable[0, 0];
    }
}
