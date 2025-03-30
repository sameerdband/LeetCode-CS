using LeetCode._000;

namespace LeetCode.Test._000;

public class _0002_AddTwoNumbers_Test
{
    private ListNode _l1;
    private ListNode _l2;

    [SetUp]
    public void Setup()
    {
        _l1 = new(2, new(4, new(3)));
        _l2 = new(5, new(6, new(4)));
    }

    [Test]
    public void AddTwoNumbers_ValidInput_ReturnsCorrectSum()
    {
        // Arrange
        _0002_AddTwoNumbers solution = new();

        // Act
        ListNode result = solution.AddTwoNumbers(_l1, _l2);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result.val, Is.EqualTo(7));
            Assert.That(result.next?.val, Is.EqualTo(0));
            Assert.That(result.next?.next?.val, Is.EqualTo(8));
        });
    }

    [Test]
    public void AddTwoNumbers_EmptyLists_ReturnsNull()
    {
        // Arrange
        ListNode? l1 = null;
        ListNode? l2 = null;
        _0002_AddTwoNumbers solution = new();

        // Act
        ListNode result = solution.AddTwoNumbers(l1!, l2!);

        // Assert
        Assert.That(result, Is.Null);
    }

    [Test]
    public void AddTwoNumbers_OneListEmpty_ReturnsOtherList()
    {
        // Arrange
        ListNode l1 = new(1, new(2, new(3)));
        ListNode? l2 = null;
        _0002_AddTwoNumbers solution = new();

        // Act
        ListNode result = solution.AddTwoNumbers(l1, l2!);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result.val, Is.EqualTo(1));
            Assert.That(result.next?.val, Is.EqualTo(2));
            Assert.That(result.next?.next?.val, Is.EqualTo(3));
        });
    }

    [Test]
    public void AddTwoNumbers_CarryOver_ReturnsCorrectSum()
    {
        // Arrange
        ListNode l1 = new(9, new(9, new(9)));
        ListNode l2 = new(1);
        _0002_AddTwoNumbers solution = new();

        // Act
        ListNode result = solution.AddTwoNumbers(l1, l2);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result.val, Is.EqualTo(0));
            Assert.That(result.next?.val, Is.EqualTo(0));
            Assert.That(result.next?.next?.val, Is.EqualTo(0));
            Assert.That(result.next?.next?.next?.val, Is.EqualTo(1));
        });
    }

    [Test]
    public void AddTwoNumbers_DifferentLengths_ReturnsCorrectSum()
    {
        // Arrange
        ListNode l1 = new(1, new(8));
        ListNode l2 = new(0);
        _0002_AddTwoNumbers solution = new();

        // Act
        ListNode result = solution.AddTwoNumbers(l1, l2);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result.val, Is.EqualTo(1));
            Assert.That(result.next?.val, Is.EqualTo(8));
        });
    }

    [Test]
    public void AddTwoNumbers_LargeLists_PerformanceTest()
    {
        // Arrange
        ListNode l1 = GenerateLargeList(1000000, 1);
        ListNode l2 = GenerateLargeList(1000000, 9);
        _0002_AddTwoNumbers solution = new();

        // Act
        ListNode result = solution.AddTwoNumbers(l1, l2);

        var cts = new CancellationTokenSource(50); // Timeout in milliseconds

        // Act & Assert
        Assert.DoesNotThrowAsync(
            async () =>
            {
                ListNode result = await Task.Run(() => solution.AddTwoNumbers(l1, l2), cts.Token);
                Assert.That(result, Is.Not.Null);
            },
            "The operation took too long to complete."
        );

        // Assert
        Assert.That(result, Is.Not.Null);
    }

    private ListNode GenerateLargeList(int size, int value)
    {
        ListNode head = new(value);
        ListNode current = head;
        for (int i = 1; i < size; i++)
        {
            current.next = new(value);
            current = current.next;
        }
        return head;
    }
}
