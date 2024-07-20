namespace CodeWars.Kata.Kyu7;

public static partial class Kata
{
    public static string Solution(string numbers)
    {
        var listOfStrings = numbers.Split(" ");
        int? lowestNr = default;
        int? highestNr = default;
        foreach (var number in listOfStrings)
        {
            if (int.TryParse(number, out var parsedNr))
            {
                if (!lowestNr.HasValue || lowestNr > parsedNr)
                {
                    lowestNr = parsedNr;
                }
                if (!highestNr.HasValue || highestNr < parsedNr)
                {
                    highestNr = parsedNr;
                }

            }
        }
        // Code here or
        return $"{highestNr!.Value} {lowestNr!.Value}";
    }
}

public class HighAndLowTests
{
    [Fact]
    public void Test1()
    {
        Assert.Equal("42 -9", Kata.Solution("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));
    }
    [Fact]
    public void Test2()
    {
        Assert.Equal("3 1", Kata.Solution("1 2 3"));
    }
}
