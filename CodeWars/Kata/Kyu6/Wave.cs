namespace CodeWars.Kata.Kyu6;

public static class Wave
{
    public static List<string> Solution(string input)
    {
        var result = new List<string>();
        if (string.IsNullOrWhiteSpace(input))
        {
            return result;
        }

        for (var index = 0; index < input.Length; index++)
        {
            var tmp = new string(input).ToCharArray();
            var letter = tmp[index];

            if (!char.IsLower(letter) || !char.IsLetter(letter)) continue;
            tmp[index] = char.ToUpper(letter);
            result.Add(new string(tmp));
        }

        return result;
    }
}

public class WaveTests
{
    [Fact]
    public void EmptyWord()
    {
        Assert.Equal(Array.Empty<string>(), Wave.Solution(""));
    }

    [Fact]
    public void SingleWord()
    {
        Assert.Equal(new[] { "Hello", "hEllo", "heLlo", "helLo", "hellO" }, Wave.Solution("hello"));
    }

    [Fact]
    public void MultipleWords()
    {
        Assert.Equal(
            new[]
            {
                "Two words", "tWo words", "twO words", "two Words", "two wOrds", "two woRds", "two worDs", "two wordS"
            }, Wave.Solution("two words"));
    }

    [Fact]
    public void WhiteSpaceInWords()
    {
        Assert.Equal(new[] { " Gap ", " gAp ", " gaP " }, Wave.Solution(" gap "));
    }
}