using LeetCode._001;

namespace LeetCode.Test._001;

public class _0019_RemoveNthNodeFromEnd_Tests
{
    [TestCase(1, 2, 3, 4, 5, 2, 1, 2, 3, 5)]
    [TestCase(1, 2, 3, 4, 5, 1, 1, 2, 3, 4)]
    [TestCase(1, 2, 3, 4, 5, 3, 1, 2, 4, 5)]
    [TestCase(1, 2, 3, 4, 5, 4, 1, 3, 4, 5)]
    [TestCase(1, 2, 3, 4, 5, 5, 2, 3, 4, 5)]
    public void RemoveNthFromEnd_Test(
        int n1,
        int n2,
        int n3,
        int n4,
        int n5,
        int n,
        int r1,
        int r2,
        int r3,
        int r4
    )
    {
        // Arrange
        _0019_RemoveNthNodeFromEnd solution = new();
        ListNode head = new(n1) { next = new ListNode(n2) };
        head.next.next = new ListNode(n3) { next = new ListNode(n4) };
        head.next.next.next.next = new ListNode(n5);

        // Act
        var result = solution.RemoveNthFromEnd(head, n);

        // Assert
        Assert.That(
            result.val == r1
                && result.next!.val == r2
                && result.next.next!.val == r3
                && result.next.next.next!.val == r4
        );
    }
}
