using System;
using System.Text.RegularExpressions;

namespace _24
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex reg = new Regex(@"(?<number>.)\k<number>+");
            string input = Console.ReadLine();
            string constant = input;

            for (int i = 0; i < reg.Matches(constant).Count ; i++)
            {
                
                Console.Write(reg.Match(input).Groups[1]);
                input = input.Replace(reg.Match(input).ToString(), "");
            }
            
        }
    }
}
