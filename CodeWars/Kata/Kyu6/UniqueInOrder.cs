namespace CodeWars.Kata.Kyu6;

//Implement the function unique_in_order which takes as argument a sequence and returns a list of items without any elements with the same value next to each other and preserving the original order of elements.
//For example:
//uniqueInOrder("AAAABBBCCDAABBB") == {'A', 'B', 'C', 'D', 'A', 'B'}
//uniqueInOrder("ABBCcAD") == { 'A', 'B', 'C', 'c', 'A', 'D'}
//uniqueInOrder([1, 2, 2, 3, 3]) == { 1,2,3}

public static partial class Kata
{
    public static IEnumerable<T> Solution<T>(IEnumerable<T> iterable)
    {
        T previous = default!;
        foreach (T current in iterable)
        {
            if (!current!.Equals(previous))
            {
                previous = current;
                yield return current;
            }
        }
    }
}

public class UniqueInOrderTests
{
    [Fact]
    public void EmptyTest()
    {
        Assert.Equal("", Kata.Solution(""));
    }

    [Theory]
    [MemberData(nameof(GetEnumerableData))]
    public void Test2<T>(IEnumerable<T> indata, IEnumerable<T> result)
    {
        Assert.Equal(Kata.Solution(indata), result);
    }
    public static IEnumerable<object[]> GetEnumerableData()
    {
        yield return new object[] { "AAAABBBCCDAABBB", "ABCDAB" };
        yield return new object[] { new int[] { 1, 2, 2, 3, 3 }, new int[] { 1, 2, 3 } };
    }
}
