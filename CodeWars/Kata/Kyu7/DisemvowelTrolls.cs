namespace CodeWars.Kata.Kyu7;

public static partial class Kata
{
    public static string Disemvowel(string str)
    {
        return new string(str.Where(c => !"aeiouAEIOU".Contains(c)).ToArray());
    }
}

public class DisemvowelTrollsTests
{
    [Fact]
    public void Disemvowel_ShouldRemoveVowelsFromString()
    {
        // Arrange
        string input = "Hello World!";
        string expected = "Hll Wrld!";

        // Act
        string result = Kata.Disemvowel(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Disemvowel_ShouldHandleEmptyString()
    {
        // Arrange
        string input = "";
        string expected = "";

        // Act
        string result = Kata.Disemvowel(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Disemvowel_ShouldHandleStringWithNoVowels()
    {
        // Arrange
        string input = "Hll Wrld!";
        string expected = "Hll Wrld!";

        // Act
        string result = Kata.Disemvowel(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Disemvowel_ShouldHandleStringWithOnlyVowels()
    {
        // Arrange
        string input = "aeiouAEIOU";
        string expected = "";

        // Act
        string result = Kata.Disemvowel(input);

        // Assert
        Assert.Equal(expected, result);
    }
}

