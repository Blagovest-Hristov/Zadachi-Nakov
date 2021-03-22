using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Zadacha10
{
    class Program
    {
        static void Main(string[] args)
        {
            string patternWord = Console.ReadLine();
            string[] usernames = Console.ReadLine().Split(". ");
            Console.WriteLine(string.Join(Environment.NewLine, usernames
                .Where(x => Regex.IsMatch(x, @"(\b)" + patternWord + @"(\b)?"))));
        }
    }
}