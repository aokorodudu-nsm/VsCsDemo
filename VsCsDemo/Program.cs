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
            var message = string.Format("{0} {1} is {2} in the {3} on {4:MMM d, yyyy}", firstName, lastName, action, location, day);

            Console.WriteLine(message);

            Console.ReadKey(true);
        }
    }
}
