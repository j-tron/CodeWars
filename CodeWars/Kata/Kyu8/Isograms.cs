namespace CodeWars.Kata.Kyu8;
//An isogram is a word that has no repeating letters, consecutive or non-consecutive.
//Implement a function that determines whether a string that contains only letters is an isogram.Assume the empty string is an isogram. Ignore letter case.

//Example: (Input --> Output)

//"Dermatoglyphics" --> true "aba" --> false "moOse" --> false (ignore letter case)
public static class IsIsogram
{
    public static bool Solution(string str)
    {
        var isogramDictionary = new HashSet<char>();
        return str.ToLower().ToCharArray().All(letter => isogramDictionary.Add(letter));
    }
}

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
        var actual = IsIsogram.Solution(str);

        //assert
        Assert.Equal(expected, actual);
    }
}