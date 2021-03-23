using System;
using System.Text.RegularExpressions;

namespace _17
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex reg = new Regex(@"/^\S+@\S+\.\S+$/");
            string input = Console.ReadLine();
            MatchCollection mc = reg.Matches(input);

            foreach (var item in mc)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
