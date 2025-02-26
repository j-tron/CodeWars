namespace CodeWars.Kata.Kyu7;

public static class JadenCase
{
    public static string Solution(string input)
    {
        return string.Join(" ", ToUpper(input));
    }

    private static IEnumerable<string> ToUpper(string input)
    {
        foreach (var c in input.Split(" "))
        {
            var list = c.ToCharArray();
            list[0] = char.ToUpper(list[0]);

            yield return new string(list);
        }
    }
}

public class JadenCaseTests
{
    [Fact]
    public void JadenCaseTest()
    {
        Assert.Equal("How Can Mirrors Be Real If Our Eyes Aren't Real",
            JadenCase.Solution("How can mirrors be real if our eyes aren't real"));
    }
}