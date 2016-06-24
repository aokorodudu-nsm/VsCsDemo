using System;
using System.Collections.Generic;

namespace VsCsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 1) throw new ArgumentException("There should be less than two arguments", "args");

            var person = new Person(args.Length > 0 ? args[0] : "human");

            Console.WriteLine("Hello {0}.  Today is {1}", person.Name, DateTime.Today.DayOfWeek);
            Console.WriteLine("You have {0} nicknames(s)", person.Nicknames != null ? person.Nicknames.Count : 0);

            Console.ReadKey(true);
        }
    }

    public class Person
    {
        private readonly string _name;

        public Person(string name)
        {
            _name = name;
            Score = 50;
        }

        public string Name { get { return _name; } }

        public int Score { get; set; }

        public ICollection<string> Nicknames { get; set; }
    }
}