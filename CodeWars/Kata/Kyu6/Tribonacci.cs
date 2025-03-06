namespace CodeWars.Kata.Kyu6;

public static class Tribonacci
{
    public static double[] Solution(double[] signature, int n)
    {
        var solution = signature.ToList();
        for (var i = 3; i < n; i++)
        {
            solution.Add(solution[(i - 3)..i].Sum());
        }

        return solution.Take(n).ToArray();
    }
}

public class TribonacciTests
{
    [Theory]
    [InlineData(new double[] { 1, 1, 1, 3, 5, 9, 17, 31, 57, 105 }, new double[] { 1, 1, 1 }, 10)]
    [InlineData(new double[] { 0, 0, 1, 1, 2, 4, 7, 13, 24, 44 }, new double[] { 0, 0, 1 }, 10)]
    [InlineData(new double[] { 0, 1, 1, 2, 4, 7, 13, 24, 44, 81 }, new double[] { 0, 1, 1 }, 10)]
    [InlineData(new double[] { 8, 18 }, new double[] { 8, 18, 18 }, 2)]
    [InlineData(new double[] { }, new double[] { 8, 18, 18 }, 0)]
    public void SolutionTest(double[] expected, double[] signature, int n)
    {
        Assert.Equal(expected, Tribonacci.Solution(signature, n));
    }
}