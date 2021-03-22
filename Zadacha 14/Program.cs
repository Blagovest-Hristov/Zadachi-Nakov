using System;
using System.Linq;

namespace Zadacha_14
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ").ToArray();

            for (int i = input.Length; i > 0; i--)
            {
                Console.Write(input[i-1] + " ");
            }
        }
    }
}
