using System;
using System.Collections.Generic;

namespace Dup1
{
    public class Program
    {
        // to run from Powershell: `cat input.txt | dotnet run`
        public static void Main(string[] args)
        {
            var counts = new Dictionary<string, int>();
            string line;
            while ((line = Console.In.ReadLine()) != null)
            {
                if (!counts.ContainsKey(line))
                {
                    counts[line] = 0;
                }

                counts[line]++;
            }

            foreach (var aLine in counts.Keys)
            {
                if (counts[aLine] > 1)
                {
                    Console.WriteLine($"{counts[aLine]}\t{aLine}");
                }
            }
        }
    }
}
