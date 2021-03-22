using System;
using System.Linq;

namespace Zadacha8
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var result = input.Select(t => $"U+{Convert.ToUInt16(t):X4} ").ToList();
            foreach (var item in result)
            {
                Console.Write($"\\{item}");
            }
        }
    }
}