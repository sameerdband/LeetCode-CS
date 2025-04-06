namespace LeetCode._001;

public class _0019_RemoveNthNodeFromEnd
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        ListNode first = head;
        ListNode current = head;
        ListNode prev = first;
        while (current.next is not null && n > 1)
        {
            current = current.next;
            n--;
        }

        while (current.next is not null)
        {
            prev = first;
            first = first.next!;
            current = current.next;
        }

        if (first == head)
        {
            return head.next!;
        }
        else
        {
            prev.next = first.next;
        }

        return head;
    }
}
