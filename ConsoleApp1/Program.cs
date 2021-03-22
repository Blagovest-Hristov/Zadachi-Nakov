using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool bracket = true;

            foreach (var item in input)
            {
                if (item == '(')
                {
                    bracket = false;
                }
                if (bracket == false)
                {
                    if (item == ')')
                    {
                        bracket = true;
                    }
                }
                if (item == ')' && bracket == true)
                {
                    Console.WriteLine("no");
                    return;
                }
            }
            if (bracket == false)
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine("yes");
            }
        }
    }
}