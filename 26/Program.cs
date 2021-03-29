using System;
using System.Text.RegularExpressions;

namespace _26
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex tags = new Regex(@"(\<(/?[^\>]+)\>)");
            Regex title = new Regex(@"(<title>)");
            Regex body = new Regex(@"(<body>)");
            string input = Console.ReadLine();
            foreach (var item in title.Matches(input))
            {
                input = input.Replace(title.Match(input).ToString(), "Title: ");
            }
            foreach (var item in body.Matches(input))
            {
                input = input.Replace(body.Match(input).ToString(), "Body: ");
            }
            foreach (var item in tags.Matches(input))
            {
                input = input.Replace(tags.Match(input).ToString(), " ");
            }
            Console.WriteLine(input);
        }
    }
}
