namespace CodeWars.Kata.Kyu8;

public static partial class Kata
{
    public static string Solution(string str)
    {
        return new string(str.Reverse().ToArray());
    }
}
