using System;
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
            var firstName = "Tony";
            var lastName = "Okorodudu";
            var action = "standing";
            var day = DateTime.Today;
            var location = "Conference Room";

            // Tony Okorodudu is standing in the Conference Room on 
            var message = $"{firstName} {lastName} is {action} in the {location} on {day:MMM d, yyyy}";

            Console.WriteLine(message);

            Console.ReadKey(true);
        }
    }
}
