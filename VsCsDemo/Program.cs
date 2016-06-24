using System;

namespace VsCsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(1);
            Console.WriteLine($"The id for {person.FirstName} is {person.Id}");

            Console.ReadKey(true);
        }
    }

    class Person
    {
        private readonly int _id;

        public Person(int id)
        {
            _id = id;
            FirstName = "Tony";
        }

        public int Id { get { return _id; } }

        public string FirstName { get; set; }
    }
}
