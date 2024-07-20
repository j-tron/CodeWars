using CodeWars.Kata.Kyu8;

namespace CodeWars.Tests.KataTests.EightKyu;

public class IsogramTests
{
    [Theory]
    [InlineData("Dermatoglyphics", true)]
    [InlineData("isogram", true)]
    [InlineData("moose", false)]
    [InlineData("isIsogram", false)]
    [InlineData("aba", false)]
    [InlineData("moOse", false)]
    [InlineData("thumbscrewjapingly", true)]
    [InlineData("", true)]
    public void Test(string str, bool expected)
    {
        //arrange&act
        var actual = Isograms.IsIsogram(str);

        //assert
        Assert.Equal(expected, actual);
    }
}