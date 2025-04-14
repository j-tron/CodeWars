using System.Numerics;

namespace CodeWars.Kata.Kyu4;

public static class TotalIncreasingOrDecreasingNumbers
{
    public static BigInteger Solution(int x)
    {
        if (x == 0) return 1;

        var increasing = Binomial(x + 9, 9);

        var decreasing = Binomial(x + 10, 10);

        var duplicates = 10 * x + 1;

        return increasing + decreasing - duplicates;
    }

    private static BigInteger Binomial(int n, int k)
    {
        BigInteger result = 1;
        for (var i = 1; i <= k; i++)
        {
            result = result * (n - i + 1) / i;
        }

        return result;
    }
}

public class TotalIncreasingOrDecreasingNumbersTests
{
    [Theory]
    [InlineData(100, 2)]
    [InlineData(475, 3)]
    [InlineData(1675, 4)]
    [InlineData(4954, 5)]
    [InlineData(12952, 6)]
    public void BasicTests(int expected, int power)
    {
        Assert.Equal(expected, TotalIncreasingOrDecreasingNumbers.Solution(power));
    }
}