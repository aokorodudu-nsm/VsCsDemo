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
        public Person(int id)
        {
            Id = id;
        }

        public int Id { get; }

        public string FirstName { get; set; } = "Tony";
    }
}
