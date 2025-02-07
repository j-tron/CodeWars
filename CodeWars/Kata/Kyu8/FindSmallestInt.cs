namespace CodeWars.Kata.Kyu8;

public static class FindSmallestInt
{
    public static int Solution(int[] nums)
    {
        return nums.Min();
    }
}

public class FindSmallestIntTests
{
    [Fact]
    public void Zero_ReturnsZero()
    {
        Assert.Equal(0, FindSmallestInt.Solution([]));
    }

    [Theory]
    [InlineData(2, new[] { 34, 15, 88, 2 })]
    [InlineData(-33, new int[] { 78, 56, -2, 12, 8, -33 })]
    public void ReturnsExpectedResult(int expected, int[] actual)
    {
        Assert.Equal(expected, FindSmallestInt.Solution(actual));
    }
}