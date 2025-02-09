namespace CodeWars.Kata.Kyu8;

public static class Feast
{
    public static bool Solution(string beast, string dish)
    {
        return beast[0] == dish[0] && beast[^1] == dish[^1];
    }
}

public class FeastTests
{
    [Theory]
    [InlineData("chickadee", "chocolate cake")]
    public void TrueFeast(string beast, string dish)
    {
        Assert.True(Feast.Solution(beast, dish));
    }

    [Theory]
    [InlineData("brown bear", "bear claw")]
    public void FalseFeast(string beast, string dish)
    {
        Assert.False(Feast.Solution(beast, dish));
    }
}