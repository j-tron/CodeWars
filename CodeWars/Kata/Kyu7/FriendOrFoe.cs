namespace CodeWars.Kata.Kyu7;

public static class FriendOrFoe
{
    public static IEnumerable<string> Solution(string[] names)
    {
        return names.Where(x => x.Length == 4);
    }
}

public class FriendOrFoeTests
{
    [Fact]
    public void FriendOrFoeTest()
    {
        Assert.Equal(["Mark", "Abel"], FriendOrFoe.Solution(["Mark", "Jimmy", "Abel", "Amanda"]));
    }
}