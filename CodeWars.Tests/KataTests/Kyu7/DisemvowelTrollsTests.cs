using CodeWars.Kata.Kyu7;

namespace CodeWars.Tests.KataTests.Kyu7;

public class DisemvowelTrollsTests
{
    [Fact]
    public void Disemvowel_ShouldRemoveVowelsFromString()
    {
        // Arrange
        string input = "Hello World!";
        string expected = "Hll Wrld!";

        // Act
        string result = DisemvowelTrolls.Disemvowel(input);

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
        string result = DisemvowelTrolls.Disemvowel(input);

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
        string result = DisemvowelTrolls.Disemvowel(input);

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
        string result = DisemvowelTrolls.Disemvowel(input);

        // Assert
        Assert.Equal(expected, result);
    }
}
