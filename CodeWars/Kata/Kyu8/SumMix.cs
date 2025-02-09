namespace CodeWars.Kata.Kyu8;

public static class SumMix
{
    public static int Solution(object[] input)
    {
        return input.Select(o
                => o as int?
                   ?? int.Parse(o.ToString() ?? "0"))
            .Sum();
    }
}

public class SumMixTests
{
    [Fact]
    public void OnlyIntegers()
    {
        Assert.Equal(6, SumMix.Solution([1, 2, 3]));
    }

    [Fact]
    public void OnlyStrings()
    {
        Assert.Equal(6, SumMix.Solution(["1", "2", "3"]));
    }

    [Fact]
    public void MixedIntegersAndStrings()
    {
        Assert.Equal(9, SumMix.Solution(["1", "2", "3", 3]));
    }
}