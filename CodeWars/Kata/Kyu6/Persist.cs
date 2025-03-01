namespace CodeWars.Kata.Kyu6;

public static class Persist
{
    public static int Solution(int number)
    {
        var numList = NumberToCharArray(number);
        var sum = 0;
        while (numList.Length > 1)
        {
            sum++;
            if (numList[0] == 0)
                return 0;
            numList =
                NumberToCharArray(numList
                    .Aggregate((x, y) => x * y));
        }

        return sum;
    }

    private static int[] NumberToCharArray(int number)
    {
        return number.ToString().Select(x => (int)char.GetNumericValue(x)).ToArray();
    }
}

public class PersistTests
{
    [Fact]
    public void SingleDigit()
    {
        Assert.Equal(0, Persist.Solution(3));
    }

    [Fact]
    public void TwoDigits()
    {
        Assert.Equal(1, Persist.Solution(31));
    }

    [Theory]
    [InlineData(4,999)]
    public void MultipleDigits(int expected, int input)
    {
        Assert.Equal(expected, Persist.Solution(input));
    }
}