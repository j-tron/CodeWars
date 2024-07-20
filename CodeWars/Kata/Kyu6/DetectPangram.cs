namespace CodeWars.Kata.Kyu6;

/// <summary>
/// A pangram is a sentence that contains every single letter of the alphabet at least once. 
/// For example, the sentence "The quick brown fox jumps over the lazy dog" is a pangram, because it uses the letters A-Z at least once (case is irrelevant).
/// Given a string, detect whether or not it is a pangram.Return True if it is, False if not.Ignore numbers and punctuation.
/// </summary>

public static partial class Kata
{
    private static Dictionary<char, bool> BuildDictionary() => new()
    {
    {'a', false}, {'b', false}, {'c', false}, {'d', false}, {'e', false}, {'f', false},
    {'g', false}, {'h', false}, {'i', false}, {'j', false}, {'k', false}, {'l', false},
    {'m', false}, {'n', false}, {'o', false}, {'p', false}, {'q', false}, {'r', false},
    {'s', false}, {'t', false}, {'u', false}, {'v', false}, {'w', false}, {'x', false},
    {'y', false}, {'z', false}
    };

    public static bool IsPangram(string input)
    {
        var letters = BuildDictionary();

        foreach (var letter in input.ToLower())
        {
            if (letters.ContainsKey(letter))
            {
                letters[letter] = true;
            }
        }

        foreach (var value in letters.Values)
        {
            if (!value)
            {
                return false;
            }
        }

        return true;
    }
}

public class MiddleCharacterTests
{
    [Theory]
    [InlineData("Cwm fjord bank glyphs vext quiz")]
    [InlineData("The quick brown fox jumps over the lazy dog.")]
    public void Given_Pangram_MiddleCharacter_Should_Return_True(string input)
    {
        Assert.True(Kata.IsPangram(input));
    }

    [Theory]
    [InlineData("Detect Pangram")]
    [InlineData("The quick fox jumps over the lazy dog.")]
    public void Given_No_Pangram_MiddleCharacter_Should_Return_False(string input)
    {
        Assert.False(Kata.IsPangram(input));
    }
}
