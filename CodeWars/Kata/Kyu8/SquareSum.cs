namespace CodeWars.Kata.Kyu8;

public static class SquareSum
{
    public static int Solution(int[] numbers)
    {
        return numbers.Sum(x => x * x);
    }
}

public class SquareSumTests
{
    [Fact]
    public void SquareSumTest()
    {
        Assert.Equal(30, SquareSum.Solution([1, 2, 3, 4]));
    }
}