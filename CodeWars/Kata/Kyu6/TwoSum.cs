namespace CodeWars.Kata.Kyu6;

public static class TwoSum
{
    public static int[] Solution(int[] numbers, int target)
    {
        for (var i = 0; i < numbers.Length-1; i++)
        {
            var tmp = numbers[i];
            for (var j = i+1; j < numbers.Length; j++)
            {
                if (numbers[j] + tmp == target)
                {
                    return [i, j];
                }
            }
        }
        
        return [0, 0];
    }
}

public class TwoSumTests
{
    [Fact]
    public static void TwoSumTest()
    {
        Assert.Equal(new[] { 1, 2 }, TwoSum.Solution([1234, 5678, 9012], 14690));
    }
}