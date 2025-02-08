namespace CodeWars.Kata.Kyu8;

public static class Digitizer
{
    public static long[] Solution(long number)
    {
        return number
            .ToString()
            .Reverse()
            .Select(x => long.Parse(x.ToString()))
            .ToArray();
    }
}

public class DigitizerTests
{
    [Fact]
    public void DigitizerTest()
    {
        Assert.Equal([3, 2, 1], Digitizer.Solution(123));
    }
}