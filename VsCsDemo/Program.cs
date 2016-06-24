using System;

namespace VsCsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"The class name is: {ClassName}");

            Console.WriteLine($"The sum of 1 and 2 is {Add(1, 2)}");

            Console.ReadKey(true);
        }

        static string ClassName
        {
            get { return typeof(Program).FullName; }
        }

        static int Add(int x, int y)
        {
            return x + y;
        }
    }
}
