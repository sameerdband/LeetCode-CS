using LeetCode._001;

namespace LeetCode.Test._001;

public class _0018_FourSum_Tests
{
    [Test]
    public void FourSumTest()
    {
        // Arrange
        int[] input = [1, 0, -1, 0, -2, 2];

        // Act
        var solution = new _0018_FourSum();
        var result = solution.FourSum(input, 0);

        // Assert
        List<IList<int>> excepted =
        [
            [-2, -1, 1, 2],
            [-2, 0, 0, 2],
            [-1, 0, 0, 1],
        ];
        Assert.That(result, Is.EquivalentTo(excepted));
    }

    [Test]
    public void FourSumTest_2()
    {
        // Arrange
        int[] input = [1, 4, -3, 0, 0, 0, 5, 0];
        _0018_FourSum solution = new();

        // Act
        IList<IList<int>> result = solution.FourSum(input, 0);

        // Assert
        List<IList<int>> expected =
        [
            [0, 0, 0, 0],
        ];
        Assert.That(result, Is.EquivalentTo(expected));
    }

    [Test]
    public void FourSumTest_Empty()
    {
        // Arrange
        int[] input = [];
        _0018_FourSum solution = new();

        // Act
        var result = solution.FourSum(input, 0);

        //Assert
        Assert.That(result.Count, Is.EqualTo(0));
    }

    [Test]
    public void FourSumTest_NotEnough()
    {
        _0018_FourSum solution = new();

        int[] input1 = [-1];
        var result = solution.FourSum(input1, 0);
        Assert.That(result, Is.Empty);

        int[] input2 = [-1, 0];
        result = solution.FourSum(input2, 0);
        Assert.That(result, Is.Empty);

        int[] input3 = [-1, 0, 1];
        result = solution.FourSum(input3, 0);
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void FourSumTest_AllTheSame()
    {
        int[] input = [0, 0, 0, 0, 0, 0];

        _0018_FourSum solution = new();
        var result = solution.FourSum(input, 0);
        List<IList<int>> expected =
        [
            [0, 0, 0, 0],
        ];
        Assert.That(result, Is.EquivalentTo(expected));

        result = solution.FourSum(input, 1);
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void FourSumTest_SomeDuplicate()
    {
        int[] input = [1, 0, 0, 1, 0, 0, -1, -1, 0, 0];

        _0018_FourSum solution = new();
        var result = solution.FourSum(input, 0);
        List<IList<int>> expected =
        [
            [-1, -1, 1, 1],
            [-1, 0, 0, 1],
            [0, 0, 0, 0],
        ];
        Assert.That(result, Is.EquivalentTo(expected));

        result = solution.FourSum(input, 1);
        expected =
        [
            [-1, 0, 1, 1],
            [0, 0, 0, 1],
        ];
        Assert.That(result, Is.EquivalentTo(expected));
    }
}
