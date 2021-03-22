using System;
using System.Text.RegularExpressions;

namespace _16
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex reg = new Regex(@"<a href=(.+>.+)<\/a>");

            string input = Console.ReadLine();

            input.Replace(reg.Match(input).ToString(), "[URL=…]" + reg.Match(input).Groups[1].ToString() + "/URL]");
            MatchCollection mc = reg.Matches(input);
            
            Console.WriteLine(input);
            Console.WriteLine(mc.Count);
        }
    }
}
