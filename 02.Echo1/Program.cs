using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var s = string.Empty;
            var separator = string.Empty;
            for (var i = 0; i < args.Length; i++)
            {
                s += separator + args[i];
                separator = " ";
            }

            Console.WriteLine(s);
        }
    }
}
