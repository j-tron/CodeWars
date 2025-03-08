namespace CodeWars.Kata.Kyu4;

public static class Decompose
{
    public static string? Solution(long number)
    {
        var goal = number * number;
        List<long> result = [];

        if (!CalculateSquares(number - 1, 0, goal, result))
        {
            return null;
        }

        result.Reverse();
        return string.Join(" ", result);
    }

    private static bool CalculateSquares(long number, long tmp, long goal, List<long> result)
    {
        while (true)
        {
            if (tmp == goal)
            {
                return true;
            }

            if (tmp > goal || number <= 0) return false;

            result.Add(number);
            if (CalculateSquares(number - 1, tmp + number * number, goal, result))
            {
                return true;
            }

            result.RemoveAt(result.Count - 1);

            number -= 1;
        }
    }
}

public class DecomposeTests
{
    [Fact]
    public void Decompose_ReturnsNull_WhenSolutionIsNull()
    {
        Assert.Null(Decompose.Solution(3));
    }

    [Theory]
    [InlineData("1 2 4 10", 11)]
    [InlineData("1 2 3 7 9", 12)]
    public void Decompose_Tests(string expected, int number)
    {
        Assert.Equal(expected, Decompose.Solution(number));
    }
}