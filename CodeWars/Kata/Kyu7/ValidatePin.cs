namespace CodeWars.Kata.Kyu7;

public static class ValidatePin
{
    public static bool Solution(string pin)
    {
        return pin.Length is 4 or 6 && pin.All(char.IsDigit);
    }
}

public class ValidatePinTests
{
    [Fact]
    public void MixedLetters()
    {
        Assert.False(ValidatePin.Solution("123a"));
    }

    [Theory]
    [InlineData("1")]
    [InlineData("12")]
    [InlineData("123")]
    [InlineData("12345")]
    [InlineData("1234567")]
    public void LengthTest(string pin)
    {
        Assert.False(ValidatePin.Solution(pin));
    }
    
    [Theory]
    [InlineData("1234")]
    [InlineData("123456")]
    public void PinTest(string pin)
    {
        Assert.True(ValidatePin.Solution(pin));
    }
}