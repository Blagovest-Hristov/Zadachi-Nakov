using System;
using System.Linq;
using System.Text.RegularExpressions;


namespace Zadacha11
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] forbiddenWords = Console.ReadLine().Split(", ").ToArray();
            foreach (var item in forbiddenWords)
            {
                Regex reg = new Regex(item);
                text = text.Replace(Regex.Match(text,item).ToString(), new string('*', item.Length));
            }
            Console.WriteLine(text);
        }
    }
}
