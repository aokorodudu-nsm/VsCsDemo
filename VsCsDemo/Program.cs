﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VsCsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine($"Awesome color selection!!!  Thank goodness today is {DayOfWeek.Friday}.");

            Console.ReadKey(true);
        }
    }
}
