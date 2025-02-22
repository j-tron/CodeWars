namespace CodeWars.Kata.Kyu6;

public static class AlphabetPosition
{
    public static string Solution(string text)
    {
        return string.Join(" ", text.ToLower().Where(char.IsLetter).Select(x => x - 96));
    }
}

public class AlphabetPositionTests
{
    [Fact]
    public void SingeWord()
    {
        Assert.Equal("1", AlphabetPosition.Solution("A"));
    }

    [Fact]
    public void MoreWord()
    {
        Assert.Equal("1 2 3 4 5", AlphabetPosition.Solution("ABCDE"));
    }

    [Theory]
    [InlineData("The sunset sets at twelve o' clock.",
        "20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11")]
    [InlineData("The narwhal bacons at midnight.", "20 8 5 14 1 18 23 8 1 12 2 1 3 15 14 19 1 20 13 9 4 14 9 7 8 20")]
    public void Words(string text, string expected)
    {
        Assert.Equal(expected, AlphabetPosition.Solution(text));
    }
}