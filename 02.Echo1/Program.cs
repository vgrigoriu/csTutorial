using System;

namespace Echo1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var output = string.Empty;
            var separator = string.Empty;
            for (var i = 0; i < args.Length; i++)
            {
                output += separator + args[i];
                separator = " ";
            }

            Console.WriteLine(output);
        }
    }
}
