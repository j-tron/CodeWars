using CodeWars.Kata.Kyu8;

namespace CodeWars.Tests.KataTests.EightKyu;

public class ReversedStringsTests
{
    [Fact]
    public void Solution_WithEmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = "";

        // Act
        string result = ReversedStrings.Solution(input);

        // Assert
        Assert.Equal("", result);
    }

    [Fact]
    public void Solution_WithSingleCharacterString_ReturnsSameCharacter()
    {
        // Arrange
        string input = "a";

        // Act
        string result = ReversedStrings.Solution(input);

        // Assert
        Assert.Equal("a", result);
    }

    [Fact]
    public void Solution_WithMultipleCharacterString_ReturnsReversedString()
    {
        // Arrange
        string input = "hello";

        // Act
        string result = ReversedStrings.Solution(input);

        // Assert
        Assert.Equal("olleh", result);
    }
}
