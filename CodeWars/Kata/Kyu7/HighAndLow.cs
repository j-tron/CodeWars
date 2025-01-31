namespace CodeWars.Kata.Kyu7;

public static class HighAndLow
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

        return $"{highestNr!.Value} {lowestNr!.Value}";
    }
}

public class HighAndLowTests
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