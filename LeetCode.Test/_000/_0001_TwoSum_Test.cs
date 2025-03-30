using LeetCode._000;

namespace LeetCode.Test._000;

public class _0001_TwoSum_Test
{
    private readonly int[] _largeArray = new int[1000000];

    [SetUp]
    public void Setup()
    {
        for (int i = 0; i < _largeArray.Length; i++)
        {
            _largeArray[i] = i + 1;
        }
    }

    [Test]
    public void TwoSum_OrderedArray_ReturnsCorrectIndices()
    {
        // Arrange
        int[] nums = [1, 2, 3, 4, 5];
        int target = 9;

        // Act
        _0001_TwoSum solution = new();
        int[] result = solution.TwoSum(nums, target);

        // Assert
        Assert.That(result, Is.EqualTo(new[] { 3, 4 }));
    }

    [Test]
    public void TwoSum_UnorderedArray_ReturnsCorrectIndices()
    {
        // Arrange
        int[] nums = [4, 1, 5, 2, 3];
        int target = 6;

        // Act
        _0001_TwoSum solution = new();
        int[] result = solution.TwoSum(nums, target);

        // Assert
        Assert.That(result, Is.EqualTo(new[] { 1, 2 }));
    }

    [Test]
    public void TwoSum_NoSolution_ReturnsEmptyArray()
    {
        // Arrange
        int[] nums = [1, 2, 3, 4, 5];
        int target = 10;

        // Act
        _0001_TwoSum solution = new();
        int[] result = solution.TwoSum(nums, target);

        // Assert
        Assert.That(result, Is.EqualTo(Array.Empty<int>()));
    }

    [Test]
    public void TwoSum_SingleElementArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] nums = [1];
        int target = 2;

        // Act
        _0001_TwoSum solution = new();
        int[] result = solution.TwoSum(nums, target);

        // Assert
        Assert.That(result, Is.EqualTo(Array.Empty<int>()));
    }

    [Test]
    [Timeout(100)]
    public void TwoSum_LargeArray_ReturnsCorrectIndices()
    {
        // Arrange
        int target = _largeArray.Length + (_largeArray.Length - 1);

        // Act
        _0001_TwoSum solution = new();
        int[] result = solution.TwoSum(_largeArray, target);

        // Assert
        Assert.That(result, Is.EqualTo(new[] { _largeArray.Length - 2, _largeArray.Length - 1 }));
    }

    [Test]
    [Timeout(50)]
    public void TwoSum_LargeArray_MiddleElements_ReturnsCorrectIndices()
    {
        // Arrange
        int middleIndex1 = _largeArray.Length / 2 - 1;
        int middleIndex2 = _largeArray.Length / 2;
        int target = _largeArray[middleIndex1] + _largeArray[middleIndex2];

        // Act
        _0001_TwoSum solution = new _0001_TwoSum();
        int[] result = solution.TwoSum(_largeArray, target);

        // Assert
        Assert.That(result, Is.EqualTo(new[] { middleIndex1, middleIndex2 }));
    }

    [Test]
    [Timeout(100)]
    public void TwoSum_LargeArray_NoSolution_ReturnsEmptyArray()
    {
        // Arrange

        int target = -5; // No two numbers in the array can sum to -5

        // Act
        _0001_TwoSum solution = new _0001_TwoSum();
        int[] result = solution.TwoSum(_largeArray, target);

        // Assert
        Assert.That(result, Is.EqualTo(Array.Empty<int>()));
    }

    [Test]
    public void TwoSum_NegativeNumbers_ReturnsCorrectIndices()
    {
        // Arrange
        int[] nums = [-3, 4, 3, 90];
        int target = 0;

        // Act
        _0001_TwoSum solution = new();
        int[] result = solution.TwoSum(nums, target);

        // Assert
        Assert.That(result, Is.EqualTo(new[] { 0, 2 }));
    }

    [Test]
    public void TwoSum_DuplicateNumbers_ReturnsCorrectIndices()
    {
        // Arrange
        int[] nums = [3, 3];
        int target = 6;

        // Act
        _0001_TwoSum solution = new();
        int[] result = solution.TwoSum(nums, target);

        // Assert
        Assert.That(result, Is.EqualTo(new[] { 0, 1 }));
    }
}
