using System;
using System.IO;
using System.Linq;

namespace Dup3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // usage: `dotnet run input1.txt input2.txt`
            var counts = (from fileName in args
                          from line in File.ReadLines(fileName)
                          group line by line into lines
                          where lines.Count() > 1
                          select lines)
                         .ToDictionary(lines => lines.Key, lines => lines.Count());
            
            foreach (var lineCount in counts)
            {
                Console.WriteLine($"{lineCount.Value}\t{lineCount.Key}");
            }
        }
    }
}
