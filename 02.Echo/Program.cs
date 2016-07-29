using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var s = string.Empty;
            var separator = string.Empty;
            foreach (var arg in args)
            {
                s += separator + arg;
                separator = " ";
            }

            Console.WriteLine(s);
        }
    }
}
