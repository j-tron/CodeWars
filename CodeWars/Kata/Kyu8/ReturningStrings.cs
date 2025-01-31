namespace CodeWars.Kata.Kyu8;
//Make a function that will return a greeting statement that uses an input; your program should return, "Hello, <name> how are you doing today?".

//[Make sure you type the exact thing I wrote or the program may not execute properly]
public static class ReturningStrings
{
    public static string Solution(string name)
    {
        return $"Hello, {name} how are you doing today?";
    }
}

public class ReturningStringsTest
{
    [Fact]
    public void SampleTest()
    {
        Assert.Equal("Hello, Ryan how are you doing today?", ReturningStrings.Solution("Ryan"));
    }
}