namespace CodeWars.Kata.Kyu7;

public static class MinMax
{
    public static int[] Solution(int[] input)
    {
        return [input.Min(), input.Max()];
    }
}

public static class MinMaxTests
{
    [Fact]
    public static void TestMinMax()
    {
        Assert.Equal(new[] { -1, 20 }, MinMax.Solution([1, 2, 5, -1, 12, 20]));
    }
}