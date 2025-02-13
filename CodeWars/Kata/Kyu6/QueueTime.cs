namespace CodeWars.Kata.Kyu6;

public static class QueueTime
{
    public static long Solution(int[] customers, int checkoutTills)
    {
        var time = 0;
        var tills = new int[checkoutTills];
        var queue = new Queue<int>(customers);
        while (true)
        {
            if (tills.All(x => x < 1) && queue.Count == 0)
            {
                return time;
            }

            for (var j = 0; j < tills.Length; j++)
            {
                if (tills[j] == 0 && queue.Count > 0)
                {
                    tills[j] = queue.Dequeue();
                }

                tills[j]--;
            }

            time++;
        }
    }
}

public class QueueTimeTests
{
    [Theory]
    [InlineData(
        new[] { 5, 3, 4 }, 1, 12)]
    public void SingleLine(int[] customers, int checkoutTills, int expected)
    {
        Assert.Equal(expected, QueueTime.Solution(customers, checkoutTills));
    }

    [Theory]
    [InlineData(
        new[] { 10, 2, 3, 3 }, 2, 10)]
    [InlineData(
        new[] { 2, 3, 10 }, 2, 12)]
    [InlineData(
        new[] { 2, 2, 3, 3, 4, 4 }, 2, 9)]
    public void MultipleLines(int[] customers, int checkoutTills, int expected)
    {
        Assert.Equal(expected, QueueTime.Solution(customers, checkoutTills));
    }
}