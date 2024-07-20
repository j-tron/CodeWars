using CodeWars.Kata.Kyu7;


namespace CodeWars.Tests.KataTests.Kyu7;

public class DnaStrandTest
{
    [Theory]
    [InlineData("AAAA", "TTTT")]
    [InlineData("ATTGC", "TAACG")]
    [InlineData("GTAT", "CATA")]
    [InlineData("AAGG", "TTCC")]
    [InlineData("CGCG", "GCGC")]
    [InlineData("GTATCGATCGATCGATCGATTATATTTTCGACGAGATTTAAATATATATATATACGAGAGAATACAGATAGACAGATTA", "CATAGCTAGCTAGCTAGCTAATATAAAAGCTGCTCTAAATTTATATATATATATGCTCTCTTATGTCTATCTGTCTAAT")]
    public void SampleTests(string dna, string expected)
    {
        Assert.Equal(expected, DnaStrand.MakeComplement(dna));
    }
}
