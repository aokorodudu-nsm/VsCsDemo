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
            var borrower = new Borrower { FirstName = "Tony" };
            
            Console.WriteLine(borrower.SubjectProperty?.AddressLine1 ?? "TBD");

            Console.ReadKey(true);
        }
    }

    class Borrower
    {
        public string FirstName { get; set; }
        public Address SubjectProperty { get; set; }
    }

    class Address
    {
        public string AddressLine1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
    }
}
