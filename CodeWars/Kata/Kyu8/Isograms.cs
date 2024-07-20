namespace CodeWars.Kata.Kyu8;
//An isogram is a word that has no repeating letters, consecutive or non-consecutive.
//Implement a function that determines whether a string that contains only letters is an isogram.Assume the empty string is an isogram. Ignore letter case.

//Example: (Input --> Output)

//"Dermatoglyphics" --> true "aba" --> false "moOse" --> false (ignore letter case)
public static partial class Kata
{
    public static bool IsIsogram(string str)
    {
        var isogramDictionary = new HashSet<char>();
        foreach (var letter in str.ToLower().ToCharArray())
        {
            if (!isogramDictionary.Add(letter))
            {
                return false;
            }
        }
        return true;
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
        var actual = Kata.IsIsogram(str);

        //assert
        Assert.Equal(expected, actual);
    }
}
