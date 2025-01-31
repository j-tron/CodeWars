using System.Text.RegularExpressions;

namespace CodeWars.Kata.Kyu4;

/// <summary>
/// Write a function that, given a string of text (possibly with punctuation and line-breaks), returns an array of the top-3 most occurring words, in descending order of the number of occurrences.
/// Assumptions:
/// A word is a string of letters (A to Z) optionally containing one or more apostrophes (') in ASCII.
///     Apostrophes can appear at the start, middle or end of a word ('abc, abc', 'abc', ab'c are all valid)
/// Any other characters (e.g. #, \, / , . ...) are not part of a word and should be treated as whitespace.
///     Matches should be case-insensitive, and the words in the result should be lowercased.
/// Ties may be broken arbitrarily.
/// If a text contains fewer than three unique words, then either the top-2 or top-1 words should be returned, or an empty array if a text contains no words.
/// </summary>
public class TopWords
{
    public static List<string> Solution(string s)
    {
        var replacedString = Regex.Replace(s.ToLowerInvariant(), @"[^a-z'\s]+", " ");

        if (!replacedString.Any(char.IsLetter))
        {
            return Array.Empty<string>().ToList();
        }

        return replacedString
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .GroupBy(word => word)
            .Select(group => new { Word = group.Key, Count = group.Count() })
            .OrderByDescending(word => word.Count)
            .Take(3)
            .Select(word => word.Word)
            .ToList();
    }
}

public class TopWordsTests
{
    [Fact]
    public void Upper_And_Lower_Returns_Expected_Result()
    {
        Assert.Equal(new[] { "e", "ddd", "aa" },
            TopWords.Solution("e e e e DDD ddd DdD: ddd ddd aa aA Aa, bb cc cC e e e"));
    }

    [Fact]
    public void Long_Text_Returns_Expected_Result()
    {
        Assert.Equal(new[] { "a", "of", "on" }, TopWords.Solution("""
                                                                  In a village of La Mancha, the name of which I have no desire to call to
                                                                  mind, there lived not long since one of those gentlemen that keep a lance
                                                                  in the lance-rack, an old buckler, a lean hack, and a greyhound for
                                                                  coursing. An olla of rather more beef than mutton, a salad on most
                                                                  nights, scraps on Saturdays, lentils on Fridays, and a pigeon or so extra
                                                                  on Sundays, made away with three-quarters of his income.
                                                                  """));
    }

    [Fact]
    public void Double_Whitespace_Expected_Result()
    {
        Assert.Equal(new[] { "e", "d", "a" },
            TopWords.Solution("a a a  b  c c  d d d d  e e e e e"));
    }

    [Fact]
    public void Special_Characters_Removed()
    {
        Assert.Equal(new[] { "won't", "wont" },
            TopWords.Solution("  //wont won't won't "));
    }

    [Fact]
    public void Only_Special_Character_Returns_Empty_Array()
    {
        Assert.Equal(Array.Empty<string>(), TopWords.Solution(" ' "));
    }

    [Fact]
    public void Only_Special_Characters_Returns_Empty_Array()
    {
        Assert.Equal(Array.Empty<string>(), TopWords.Solution(" ''' "));
    }
}