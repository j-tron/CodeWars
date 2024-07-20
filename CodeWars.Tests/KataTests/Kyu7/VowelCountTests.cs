using CodeWars.Kata.Kyu7;

namespace CodeWars.Tests.KataTests.Kyu7;

public class VowelCountTests
{
    [Fact]
    public void TestCase1()
    {
        Assert.Equal(5, VowelCount.GetVowelCount("abracadabra"));
    }
}
