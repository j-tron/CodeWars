namespace CodeWars.Kata.Kyu7;

public static partial class Kata
{
    public static string GetMiddle(string str)
    {
        var result = Math.DivRem(str.Length, 2, out var remainder);

        return str.Substring(result - 1 + remainder, 2 - remainder);
    }
}

public class MiddleCharacterTests
{
    [Theory]
    [InlineData("test", "es")]
    [InlineData("testing", "t")]
    [InlineData("middle", "dd")]
    [InlineData("A", "A")]
    public void Given_Input_MiddleCharacter_Should_ReturnGenericTests(string input, string result)
    {
        Assert.Equal(Kata.GetMiddle(input), result);
    }
}
