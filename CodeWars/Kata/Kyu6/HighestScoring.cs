namespace CodeWars.Kata.Kyu6;

public static class HighestScoring
{
    public static string Solution(string s)
    {
        return s.Split(" ")
            .Select(x => (score: x.Sum(t1 => t1 - 'a' + 1), word: x))
            .OrderByDescending(x => x.score)
            .FirstOrDefault().word;
    }
}

public class HighestScoringTests
{
    [Theory]
    [InlineData("man i need a taxi up to ubud", "taxi")]
    [InlineData("what time are we climbing up to the volcano", "volcano")]
    [InlineData("take me to semynak", "semynak")]
    public void HighestScoringTest(string input, string expected)
    {
        Assert.Equal(expected, HighestScoring.Solution(input));
    }
}