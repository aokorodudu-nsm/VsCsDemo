using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;
using static System.DayOfWeek;

namespace VsCsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BackgroundColor = Magenta;
            ForegroundColor = Yellow;

            WriteLine($"Awesome color selection!!!  Thank goodness today is {Friday}.");

            ReadKey(true);
        }
    }
}
