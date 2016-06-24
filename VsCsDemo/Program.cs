using System;
using System.Data.SqlClient;

namespace VsCsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Do some database activity....
            }
            catch (SqlException ex) when (ex.ErrorCode == SqlExceptions.Timeout)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }


    class SqlExceptions
    {
        public const int Timeout = -2;
    }
}
