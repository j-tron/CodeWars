namespace CodeWars.Kata.Kyu8;

public static class ReversedStrings
{
    public static string Solution(string str)
    {
        return new string(str.Reverse().ToArray());
    }
}