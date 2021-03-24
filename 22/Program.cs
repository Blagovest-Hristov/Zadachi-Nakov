using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _22
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex reg = new Regex(@"\w");
            string input = Console.ReadLine();
            string result ="";
            Dictionary<string, int> dic = new Dictionary<string, int>();
            foreach (var item in reg.Matches(input))
            {
                result += item.ToString();
                if (dic.ContainsKey(item.ToString()))
                {
                    dic[item.ToString()]++;
                }
                else
                {
                    dic.Add(item.ToString(), 1);
                }
            }
            char[] a = result.ToCharArray();
            Array.Sort(a);
            result = new string(a);
            Console.WriteLine(result);
            foreach (var item in dic)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }
        }
    }
}

