using System;
using System.Diagnostics;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] testCases =
        {
            "The quick brown fox jumps over the lazy dog",
            "Hello world!",
            "C# is awesome",
            "Supercalifragilisticexpialidocious is a long word",
            "",
            "A B C D E F G"
        };

        foreach (var test in testCases)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            string longestWord = FindLongestWord(test);
            stopwatch.Stop();

            Console.WriteLine($"Sentence: \"{test}\"");
            Console.WriteLine($"Longest Word: {longestWord}");
            Console.WriteLine($"Execution Time: {stopwatch.ElapsedTicks} ticks\n");
        }
    }

    public static string FindLongestWord(string sentence)
    {
        if (string.IsNullOrEmpty(sentence)) return string.Empty;
        return sentence.Split(' ')
                       .OrderByDescending(word => word.Length)
                       .FirstOrDefault();
    }
}