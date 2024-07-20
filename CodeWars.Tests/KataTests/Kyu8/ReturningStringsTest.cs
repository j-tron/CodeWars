using CodeWars.Kata.Kyu8;

namespace CodeWars.Tests.KataTests.EightKyu;

public class ReturningStringsTest
{
    [Fact]
    public void SampleTest()
    {
        Assert.Equal("Hello, Ryan how are you doing today?", ReturningStrings.Greet("Ryan"));
    }
}
