using System;
using System.Text.RegularExpressions;

namespace Zadachi_Nakov
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex reg = new Regex(@"(.+):\/\/(www\..+\.\w+)(\/.+\..+)");
            string input = Console.ReadLine();
            Match match = reg.Match(input);
            Console.WriteLine("[protocol] = " + match.Groups[1].ToString());
            Console.WriteLine("[server] = " + match.Groups[2].ToString());
            Console.WriteLine("[resource] = " + match.Groups[3].ToString());


        }
    }
}
