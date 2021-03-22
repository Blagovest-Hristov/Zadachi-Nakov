using System;
using System.Text.RegularExpressions;
using System.Linq;
namespace uppercaseTag
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex rg = new Regex(@"<([^>]+)>(?<content>[^>]+)</\1>");
            Match match = rg.Match(input);
            Console.WriteLine(rg.Replace(input, match.Groups["content"].Value.ToUpper()));
        }
    }
}