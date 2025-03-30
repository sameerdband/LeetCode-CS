namespace LeetCode._000;

public class _0007_ReverseInteger
{
    public int Reverse(int x)
    {
        int result = 0;
        int positiveOverflow = int.MaxValue / 10;
        int nagativeOverflow = int.MinValue / 10;
        while (x != 0)
        {
            if (result > positiveOverflow || result < nagativeOverflow)
            {
                return 0; // Overflow occurred
            }

            result = result * 10 + x % 10;
            x /= 10;
        }

        return result;
    }
}
