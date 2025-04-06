namespace LeetCode._002;

public class _0020_ValidParanthesis
{
    public bool IsValid(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return true;
        }

        ReadOnlySpan<char> span = s.AsSpan();
        Span<char> stack = stackalloc char[span.Length];
        int stackPointer = 0;
        foreach (var c in span)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                stack[stackPointer++] = c;
            }
            else
            {
                if (stackPointer == 0)
                {
                    return false;
                }

                char top = stack[--stackPointer];
                if (
                    !(
                        (top == '(' && c == ')')
                        || (top == '{' && c == '}')
                        || (top == '[' && c == ']')
                    )
                )
                {
                    return false;
                }
            }
        }

        return stackPointer == 0;
    }
}
