using System;
using System.Linq;

namespace VsCsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 100);

            var divisibleBy5 = numbers.Where(number => number % 5 == 0);

            Console.WriteLine(string.Join(Environment.NewLine, divisibleBy5));

            Console.ReadKey(true);
        }
    }
}
