using System;
using System.Text.RegularExpressions;

namespace Zadacha5
{
    class Program
    {
        static void Main(string[] args)
        {
            string inp = Console.ReadLine().ToLower();
            string searchingfor = Console.ReadLine();
            int count = Regex.Matches(inp, searchingfor).Count;
            Console.WriteLine(count);
        }
    }
}
