using System.Text;

namespace CodeWars.Kata.Kyu6;

public static class BreakCamelCase
{
    public static string Solution(string input)
    {
        var words = input.Split("");
        var stringBuilder = new StringBuilder();
        foreach (var word in words)
        {
            stringBuilder.Append(SplitOnCase(word));
        }

        return stringBuilder.ToString();
    }

    private static string SplitOnCase(string word)
    {
        var finalWord = word;
        var movedIndex = 0;
        for (var index = 0; index < word.Length; index++)
        {
            var letter = word[index];

            if (char.IsUpper(letter))
            {
                finalWord = finalWord.Insert(index + movedIndex, " ");
                movedIndex++;
            }
        }

        return finalWord;
    }
}

public class BreakCamelCaseTests
{
    [Theory]
    [InlineData("camelCasing", "camel Casing")]
    [InlineData("camelCasingTest", "camel Casing Test")]
    [InlineData("camelCasingTestTest", "camel Casing Test Test")]
    public void Should_BreakCamelCase(string input, string result)
    {
        Assert.Equal(result, BreakCamelCase.Solution(input));
    }
}