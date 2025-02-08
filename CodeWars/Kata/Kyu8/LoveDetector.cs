namespace CodeWars.Kata.Kyu8;

public static class LoveDetector
{
    public static bool Solution(int firstFlower, int secondFlower)
    {
        return (firstFlower + secondFlower) % 2 == 1;
    }
}

public class LoveDetectorTests
{
    [Fact]
    public void EvenPetalsReturnsFalse()
    {
        Assert.False(LoveDetector.Solution(1, 1));
    }

    [Theory]
    [InlineData(1, 2)]
    [InlineData(12, 21)]
    [InlineData(543, 1000)]
    public void OddPetalsReturnsTrue(int firstFlower, int secondFlower)
    {
        Assert.True(LoveDetector.Solution(firstFlower, secondFlower));
    }
}