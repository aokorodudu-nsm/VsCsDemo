using Newtonsoft.Json.Linq;
using System;

namespace VsCsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new JObject
            {
                {"FirstName", "Tony" },
                { "LastName", "Okorodudu"}
            };

            Console.WriteLine(person);

            Console.ReadKey(true);
        }
    }
}
