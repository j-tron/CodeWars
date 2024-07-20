using CodeWars.Kata.Kyu7;
namespace CodeWars.Tests.Kata.SevenKyu;

public class ExampleTests
{
    [Fact]
    public void Test1()
    {
        Assert.Equal("42 -9", HighAndLow.Solution("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));
    }
    [Fact]
    public void Test2()
    {
        Assert.Equal("3 1", HighAndLow.Solution("1 2 3"));
    }
}