using System;

namespace Zadacha7
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] charArr = Console.ReadLine().ToCharArray();
            if (charArr.Length < 19)
            {
                for (int i = charArr.Length; i < 19; i++)
                {
                    charArr[i] = '*';
                }
            }
            for (int i = 0; i < charArr.Length; i++)
            {
                Console.Write(charArr[i]);
            }
        }
    }
}