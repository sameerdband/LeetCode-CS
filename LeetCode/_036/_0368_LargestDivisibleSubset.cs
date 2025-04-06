namespace LeetCode._036;

public class _0368_LargestDivisibleSubset
{
    public IList<int> LargestDivisibleSubset(int[] nums)
    {
        Span<int> numsS = new(nums);
        numsS.Sort();
        ReadOnlySpan<int> numsSpan = numsS;

        if (numsSpan.Length < 2)
        {
            return nums;
        }

        Span<int> lengths = new(new int[numsSpan.Length]);
        Span<int> prevInd = new(new int[numsSpan.Length]);

        for (int i = 0; i < numsSpan.Length; i++)
        {
            lengths[i] = 0;
            prevInd[i] = -1;

            for (int j = 0; j < i; j++)
            {
                if (numsSpan[i] % numsSpan[j] == 0 && lengths[j] > lengths[i] - 1)
                {
                    lengths[i] = lengths[j] + 1;
                    prevInd[i] = j;
                }
            }
        }

        int maxLength = lengths[0];
        int maxIndex = 1;

        for (int i = 1; i < lengths.Length; i++)
        {
            if (maxLength < lengths[i])
            {
                maxLength = lengths[i];
                maxIndex = i;
            }
        }

        List<int> result = [];
        while (maxIndex != -1)
        {
            result.Add(numsSpan[maxIndex]);
            maxIndex = prevInd[maxIndex];
        }

        return result;
    }
}
