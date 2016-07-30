using System;
using System.Collections.Generic;
using System.IO;

namespace Dup2
{
    public class Program
    {
        // usage:
        //     cat input1.txt | dotnet run
        // or:
        //     dotnet run input1.txt input2.txt
        public static void Main(string[] args)
        {
            var counts = new Dictionary<string, int>();
            if (args.Length == 0)
            {
                CountLines(Console.In, counts);
            }
            else
            {
                foreach (var fileName in args)
                {
                    try
                    {
                        using (var reader = File.OpenText(fileName))
                        {
                            CountLines(reader, counts);
                        }
                    }
                    catch (IOException ex)
                    {
                        Console.Error.WriteLine($"Error opening {fileName}: {ex}");
                    }
                }
            }

            foreach (var line in counts.Keys)
            {
                if (counts[line] > 1)
                {
                    Console.WriteLine($"{counts[line]}\t{line}");
                }
            }
        }

        private static void CountLines(TextReader reader, Dictionary<string, int> counts)
        {
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                if (!counts.ContainsKey(line))
                {
                    counts[line] = 0;
                }

                counts[line]++;
            }
        }
    }
}
