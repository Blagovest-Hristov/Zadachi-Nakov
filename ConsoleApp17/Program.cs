using System;
using System.Linq;

namespace Zadacha22
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var frequency = from f in input
                            group f by f into letterfrequency               
                            orderby letterfrequency.Key
                            select
                            (
                                Letter: letterfrequency.Key,
                                Frequency: letterfrequency.Count()
                            );


            foreach (var (Letter, Frequency) in frequency)
            {
                Console.WriteLine($"{Letter}{Frequency}");
            }
        }
    }
}