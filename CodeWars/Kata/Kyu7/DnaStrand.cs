using System.Text;

namespace CodeWars.Kata.Kyu7;

// <summary>
// Deoxyribonucleic acid (DNA) is a chemical found in the nucleus of cells and carries the "instructions" for the development and functioning of living organisms.
//If you want to know more: http://en.wikipedia.org/wiki/DNA
//In DNA strings, symbols "A" and "T" are complements of each other, as "C" and "G".
//Your function receives one side of the DNA(string, except for Haskell); you need to return the other complementary side.DNA strand is never empty or there is no DNA at all (again, except for Haskell).
//More similar exercise are found here: http://rosalind.info/problems/list-view/ (source)
//Example: (input --> output)
//"ATTGC" --> "TAACG"
//"GTAT" --> "CATA"
// </summary>
public static class DnaStrand
{
    public static string Solution(string dna)
    {
        StringBuilder sb = new();

        foreach (var symbol in dna)
        {
            switch (symbol)
            {
                case 'A':
                    sb.Append('T');
                    break;
                case 'T':
                    sb.Append('A');
                    break;
                case 'C':
                    sb.Append('G');
                    break;
                case 'G':
                    sb.Append('C');
                    break;
                default:
                    sb.Append(symbol);
                    break;
            }
        }

        return sb.ToString();
    }
}

public class DnaStrandTest
{
    [Theory]
    [InlineData("AAAA", "TTTT")]
    [InlineData("ATTGC", "TAACG")]
    [InlineData("GTAT", "CATA")]
    [InlineData("AAGG", "TTCC")]
    [InlineData("CGCG", "GCGC")]
    [InlineData("GTATCGATCGATCGATCGATTATATTTTCGACGAGATTTAAATATATATATATACGAGAGAATACAGATAGACAGATTA",
        "CATAGCTAGCTAGCTAGCTAATATAAAAGCTGCTCTAAATTTATATATATATATGCTCTCTTATGTCTATCTGTCTAAT")]
    public void SampleTests(string dna, string expected)
    {
        Assert.Equal(expected, DnaStrand.Solution(dna));
    }
}