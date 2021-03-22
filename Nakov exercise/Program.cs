using System;
using System.Text;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            string i;
            do
            {
                i = Console.ReadLine();
                if (i == "end")
                {
                    break;
                }
                Console.WriteLine($"{i} = " + Reverse(i));
            } while (i != "end");



        }

        static string Reverse(string str)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                builder.Append(str[i]);
            }
            string newName = builder.ToString();

            return newName;
        }
    }
}