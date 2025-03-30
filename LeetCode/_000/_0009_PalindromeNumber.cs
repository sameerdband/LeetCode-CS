namespace LeetCode._000;

public class _0009_PalindromeNumber
{
    public bool IsPalindrome(int x)
    {
        if (x < 0)
            return false; // Negative numbers are not palindromes
        if (x < 10)
            return true; // Single-digit numbers are palindromes
        if (x % 10 == 0)
            return false; // Numbers ending with 0 (except 0 itself) are not palindromes

        int reversedHalf = 0;
        while (x > reversedHalf)
        {
            reversedHalf = reversedHalf * 10 + x % 10; // Build the reversed half
            x /= 10; // Reduce the original number
        }

        // Check if the original number is equal to the reversed half or the reversed half without the last digit (for odd-length numbers)
        return x == reversedHalf || x == reversedHalf / 10;
    }
}
