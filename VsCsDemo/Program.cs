using System;

namespace VsCsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0) throw new ArgumentException("I don't want any arguments!", nameof(args));

            Console.WriteLine($"Class name: {nameof(Program)}");
            Console.WriteLine($"Method name: {nameof(Main)}");
            Console.WriteLine($"Parameter name: {nameof(args)}");

            Console.ReadKey(true);
        }
    }
}
