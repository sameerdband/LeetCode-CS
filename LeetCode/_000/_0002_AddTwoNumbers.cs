namespace LeetCode._000;

public class _0002_AddTwoNumbers
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode result = new(0);
        ListNode? p = l1,
            q = l2,
            current = result;
        int carry = 0;

        while (p is not null || q is not null)
        {
            int x = p?.val ?? 0;
            int y = q?.val ?? 0;
            int sum = carry + x + y;
            carry = sum / 10;
            current.next = new(sum % 10);
            current = current.next;

            p = p?.next;
            q = q?.next;
        }

        if (carry > 0)
        {
            current.next = new(carry);
        }

        return result.next!;
    }
}
