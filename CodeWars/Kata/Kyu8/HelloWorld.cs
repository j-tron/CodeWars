namespace CodeWars.Kata.Kyu8;

public static class HelloWorld
{
    public static string Greet() => "Hello World!";
}

public class HelloWorldTests
{
    [Fact]
    public void ReturnsHelloWorld()
    {
        Assert.Equal("Hello World!", HelloWorld.Greet());
    }
}