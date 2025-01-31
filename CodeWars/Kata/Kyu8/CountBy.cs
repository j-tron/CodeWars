namespace CodeWars.Kata.Kyu8;

/// <summary>
/// Create a function with two arguments that will return an array of the first n multiples of x.
/// Assume both the given number and the number of times to count will be positive numbers greater than 0.
/// Return the results as an array or list(depending on language ).
/// Examples
/// countBy(1,10)  should return  {1,2,3,4,5,6,7,8,9,10}
/// countBy(2, 5)  should return {2,4,6,8,10}
/// </summary>
public static class CountBy
{
    public static int[] Solution(int x, int n)
    {
        return Enumerable.Range(1, n).Select(i => i * x).ToArray();
    }
}

public class CountByTests
{
    [Fact]
    public static void CountBy1()
    {
        Assert.Equal(new[] { 1, 2, 3, 4, 5 }, CountBy.Solution(1, 5));
    }

    [Fact]
    public static void CountBy2()
    {
        Assert.Equal(new[] { 2, 4, 6, 8, 10 }, CountBy.Solution(2, 5));
    }
}