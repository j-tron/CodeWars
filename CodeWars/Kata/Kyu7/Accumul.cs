using System.Text;

namespace CodeWars.Kata.Kyu7;

public static class Accumul
{
    public static string Solution(string input)
    {
        var accumulator = 0;
        var result = new StringBuilder();
        foreach (var letter in input)
        {
            if (accumulator > 0)
            {
                result.Append('-');
            }

            result.Append(char.ToUpper(letter) + new string(char.ToLower(letter), accumulator));
            accumulator++;
        }

        return result.ToString();
    }
}

public class AccumulTests
{
    [Fact]
    public void SingleLetter()
    {
        Assert.Equal("A", Accumul.Solution("a"));
    }

    [Fact]
    public void ManyLetter()
    {
        Assert.Equal("A-Bb", Accumul.Solution("ab"));
    }

    [Theory]
    [InlineData("Z-Pp-Ggg-Llll-Nnnnn-Rrrrrr-Xxxxxxx-Qqqqqqqq-Eeeeeeeee-Nnnnnnnnnn-Uuuuuuuuuuu", "ZpglnRxqenU")]
    [InlineData("N-Yy-Fff-Ffff-Sssss-Gggggg-Eeeeeee-Yyyyyyyy-Yyyyyyyyy-Llllllllll-Bbbbbbbbbbb", "NyffsGeyylB")]
    public void ManyCombinationsOfLetters(string expected, string actual)
    {
        Assert.Equal(expected, Accumul.Solution(actual));
    }
}