namespace CodeWars.Kata.Kyu7;

//Return the number(count) of vowels in the given string.
//We will consider a, e, i, o, u as vowels for this Kata (but not y).
//The input string will only consist of lower case letters and/or spaces.

public static class VowelCount
{
    public static int Solution(string str)
    {
        return str.Count(x => "aeiou".Contains(x));
    }
}

public class VowelCountTests
{
    [Fact]
    public void TestCase1()
    {
        Assert.Equal(5, VowelCount.Solution("abracadabra"));
    }
}