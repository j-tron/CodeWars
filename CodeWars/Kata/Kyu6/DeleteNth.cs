namespace CodeWars.Kata.Kyu6;

public static class DeleteNth
{
    public static int[] Solution(int[] numbers, int occurence)
    {
        Dictionary<int, int> occurrences = new();
        var solution = new List<int>();

        foreach (var number in numbers)
        {
            if (!occurrences.TryAdd(number, 1))
            {
                occurrences[number]++;
            }

            if (occurrences[number] <= occurence)
            {
                solution.Add(number);
            }
        }

        return solution.ToArray();
    }
}

public class DeleteNthTests
{
    [Fact]
    public void OccurenceOnce()
    {
        Assert.Equal(new int[] { 20, 37, 21 }, DeleteNth.Solution([20, 37, 20, 21], 1));
    }

    [Fact]
    public void OccurenceTwice()
    {
        Assert.Equal(new int[] { 1, 2, 3, 1, 2, 3 }, DeleteNth.Solution([1, 2, 3, 1, 2, 1, 2, 3], 2));
    }
}