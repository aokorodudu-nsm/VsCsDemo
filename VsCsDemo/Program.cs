using System;
using static System.Linq.Enumerable;
using static System.Environment;

namespace VsCsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Range(0, 100);

            /*
               // This is invalid
               Where(number => number % 5 == 0);
            */

            var divisibleBy5 = numbers.Where(number => number % 5 == 0);

            Console.WriteLine(string.Join(NewLine, divisibleBy5));

            Console.ReadKey(true);
        }
    }
}
