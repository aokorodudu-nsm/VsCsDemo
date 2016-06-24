using System;

namespace VsCsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0) throw new ArgumentException("I don't want any arguments!", "args");

            Console.WriteLine("Class name: Program");
            Console.WriteLine("Method name: Main");
            Console.WriteLine("Parameter name: args");

            Console.ReadKey(true);
        }
    }
}
