using System;
using System.Text.RegularExpressions;


namespace Zadacha6
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            Regex regex = new Regex(@"<([^>]+)>(?<content>[^>]+)<\/\1>");
            string cleanString = regex.Replace(testString, ProcessTag);
            Console.WriteLine(cleanString);
        }

        private static string ProcessTag(Match m)
        {
            string content = m.Groups["content"].Value;
            return content.ToUpper();
        }

    }
}