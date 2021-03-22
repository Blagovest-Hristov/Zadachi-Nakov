using System;
using System.Linq;
using System.Text;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ").ToArray();
            StringBuilder a = new StringBuilder();
            StringBuilder b = new StringBuilder();

            foreach (var item in input)
            {

              

                if(item.Length%2 != 0)
                    {

                    for (int i = 0; i < item.Length / 2; i++)
                    {
                        a.Append(item[i].ToString());
                    }
                    for (int i = item.Length - 1; i > item.Length / 2; i--)
                    {
                        b.Append(item[i].ToString());
                    }
                }
                else
                {
                    for (int i = 0; i < item.Length / 2; i++)
                    {
                        a.Append(item[i].ToString());
                    }
                    for (int i = item.Length - 1; i > item.Length / 2 - 1; i--)
                    {
                        b.Append(item[i].ToString());
                    }
                }

                if (a.ToString() == b.ToString())
                {
                    Console.Write(item + " ");
                }
                a.Clear();
                b.Clear();
            }
        }
    }
}
