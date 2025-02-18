namespace CodeWars.Kata.Kyu6;

public static class DigPow
{
    public static long Solution(int number, int power)
    {
        var numbers = number.ToString().Select(x => int.Parse(x.ToString())).ToArray()
            .Select((x, i) => (int)Math.Pow(x, i + power)).Sum();

        var divRem = Math.DivRem(numbers, number);

        return divRem.Remainder == 0 ? divRem.Quotient : -1;
    }
}

public class DigPowTests
{
    [Fact]
    public void SingleNumber()
    {
        Assert.Equal(1, DigPow.Solution(89, 1));
    }

    [Fact]
    public void NumberNoMatch()
    {
        Assert.Equal(-1, DigPow.Solution(92, 1));
    }

    [Fact]
    public void PowerOfThree()
    {
        Assert.Equal(51, DigPow.Solution(46288, 3));
    }
}