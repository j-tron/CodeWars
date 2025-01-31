namespace CodeWars.Kata.Kyu7;

public static class DisemvowelTrolls
{
    public static string Solution(string str)
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
        var input = "Hello World!";
        var expected = "Hll Wrld!";

        // Act
        var result = DisemvowelTrolls.Solution(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Disemvowel_ShouldHandleEmptyString()
    {
        // Arrange
        const string input = "";
        const string expected = "";

        // Act
        var result = DisemvowelTrolls.Solution(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Disemvowel_ShouldHandleStringWithNoVowels()
    {
        // Arrange
        const string input = "Hll Wrld!";
        const string expected = "Hll Wrld!";

        // Act
        var result = DisemvowelTrolls.Solution(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Disemvowel_ShouldHandleStringWithOnlyVowels()
    {
        // Arrange
        const string input = "aeiouAEIOU";
        const string expected = "";

        // Act
        var result = DisemvowelTrolls.Solution(input);

        // Assert
        Assert.Equal(expected, result);
    }
}