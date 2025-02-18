namespace CodeWars.Kata.Kyu6;

public static class FindOdd
{
    public static int Solution(int[] numbers)
    {
        return numbers.GroupBy(x => x).Single(x => x.Count() % 2 == 1).Key;
    }
}

public class FindOddTests
{
    [Fact]
    public void SingleDigit()
    {
        Assert.Equal(10, FindOdd.Solution([10]));
    }

    [Fact]
    public void MultipleDigits()
    {
        Assert.Equal(5, FindOdd.Solution([20,1,-1,2,-2,3,3,5,5,1,2,4,20,4,-1,-2,5]));
    }
}