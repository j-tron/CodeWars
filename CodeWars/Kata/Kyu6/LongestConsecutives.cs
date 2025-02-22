namespace CodeWars.Kata.Kyu6;

public static class LongestConsecutives
{
    public static string Solution(string[] input, int k)
    {
        if (input.Length < k || input.Length == 0 || k < 1)
        {
            return "";
        }

        (int index, string word) highestLength = (0, "");
        for (var i = 0; i < input.Length + 1 - k; i++)
        {
            var word = string.Join("", input[i..(i + k)]);
            if (word.Length > highestLength.index)
            {
                highestLength.index = word.Length;
                highestLength.word = word;
            }
        }

        return highestLength.word;
    }
}

public class LongestConsecutivesTests
{
    [Fact]
    public void LongestWordWithK1()
    {
        Assert.Equal("oocccffuucccjjjkkkjyyyeehh",
            LongestConsecutives.Solution(
                ["ejjjjmmtthh", "zxxuueeg", "aanlljrrrxx", "dqqqaaabbb", "oocccffuucccjjjkkkjyyyeehh"], 1));
    }

    [Fact]
    public void LongestWordWithK2()
    {
        Assert.Equal("abigailtheta",
            LongestConsecutives.Solution(["zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail"], 2));
    }

    [Fact]
    public void LongestWordWithK3()
    {
        Assert.Equal("ixoyx3452zzzzzzzzzzzz",
            LongestConsecutives.Solution(["it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz"], 3));
    }
}