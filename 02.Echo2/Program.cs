using System;

namespace Echo2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var output = string.Empty;
            var separator = string.Empty;
            foreach (var arg in args)
            {
                output += separator + arg;
                separator = " ";
            }

            Console.WriteLine(output);
        }
    }
}
