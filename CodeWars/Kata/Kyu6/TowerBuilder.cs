namespace CodeWars.Kata.Kyu6;

public static class TowerBuilder
{
    public static string[] Solution(int floors)
    {
        return new string[floors]
            .Select((x, i) =>
                GetSpaces(floors, i) +
                GetStars(i) +
                GetSpaces(floors, i)).ToArray();
    }

    private static string GetStars(int i)
    {
        return new string('*', 2 * i + 1);
    }

    private static string GetSpaces(int floors, int i)
    {
        return new string(' ', floors - i - 1);
    }
}

public class TowerBuilderTests
{
    [Fact]
    public void OneFloorTest()
    {
        Assert.Equal(new[] { "*" }, TowerBuilder.Solution(1));
    }

    [Fact]
    public void TwoFloorsTest()
    {
        Assert.Equal(new[] { " * ", "***" }, TowerBuilder.Solution(2));
    }

    [Fact]
    public void ThreeFloorsTest()
    {
        Assert.Equal(new[] { "  *  ", " *** ", "*****" }, TowerBuilder.Solution(3));
    }
}