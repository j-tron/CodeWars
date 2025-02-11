namespace CodeWars.Kata.Kyu6;

public static class DuplicateCount
{
    public static int Solution(string input)
    {
        var counts = new Dictionary<char, int>();
        foreach (var c in input.ToLower().Where(c => !counts.TryAdd(c, 0)))
        {
            counts[c]++;
        }

        return counts.Values.Count(x => x > 0);
    }
}

public class DuplicateCountTests
{
    [Fact]
    public void OneDuplicate()
    {
        Assert.Equal(1, DuplicateCount.Solution("aab"));
    }

    [Fact]
    public void NoDuplicate()
    {
        Assert.Equal(0, DuplicateCount.Solution("ab"));
    }

    [Theory]
    [InlineData("Indivisibilities", 2)]
    public void Duplicates(string a, int expected)
    {
        Assert.Equal(expected, DuplicateCount.Solution(a));
    }
}