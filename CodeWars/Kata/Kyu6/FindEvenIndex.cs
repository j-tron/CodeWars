namespace CodeWars.Kata.Kyu6;

public static class FindEvenIndex
{
    public static int Solution(int[] nums)
    {
        return Recursive(nums, 0);
    }

    private static int Recursive(int[] numbers, int index)
    {
        if (index == numbers.Length)
        {
            return -1;
        }

        return 
            numbers[..index].Sum() == numbers[(index + 1)..].Sum() 
            ? index 
            : Recursive(numbers, index + 1);
    }
}

public class FindEvenIndexTests
{
    [Fact]
    public void ArraySizeOne()
    {
        Assert.Equal(-1, FindEvenIndex.Solution([1]));
    }

    [Fact]
    public void ArraySizeTwo()
    {
        Assert.Equal(0, FindEvenIndex.Solution([8, 0]));
    }

    [Fact]
    public void ArraySizeThree()
    {
        Assert.Equal(1, FindEvenIndex.Solution([3, 2, 3]));
    }

    [Theory]
    [InlineData(new[] { 1, 2, 3, 4, 3, 2, 1 }, 3)]
    [InlineData(new[] { 1, 100, 50, -51, 1, 1 }, 1)]
    [InlineData(new[] { 1, 2, 3, 4, 5, 6 }, -1)]
    [InlineData(new[] { 20, 10, 30, 10, 10, 15, 35 }, 3)]
    public void MultipleArraySize(int[] num, int expected)
    {
        Assert.Equal(expected, FindEvenIndex.Solution(num));
    }
}