using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace VsCsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var movieSummary = FindMovieAsync("Independence Day").Result;

            Console.WriteLine(movieSummary);

            Console.ReadKey(true);
        }

        public static async Task<string> FindMovieAsync(string title)
        {
            using (var client = new HttpClient { BaseAddress = new Uri("http://www.omdbapi.com/") })
            {
                try
                {
                    return await client.GetStringAsync($"?t={title}&r=json");
                }
                finally
                {
                    // Not possible prior to C# 6
                    // await Logger.WriteAsync("All done");
                }
            }
        }
    }


    class Logger
    {
        public static async Task WriteAsync(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
            await Task.FromResult(0);
        }
    }
}
