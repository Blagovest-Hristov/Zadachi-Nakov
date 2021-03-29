using System;
using System.Collections.Generic;
using System.Linq;

namespace _25
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> stringList = Console.ReadLine().Split(", ").ToList();
            stringList.Sort();

            foreach (var item in stringList)
            {
                Console.Write(item + " ");
            }
        }
    }
}
