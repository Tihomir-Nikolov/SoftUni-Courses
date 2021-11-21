using System;
using System.Text.RegularExpressions;

namespace _01.Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+";
            string names = Console.ReadLine();

            MatchCollection machedName = Regex.Matches(names, regex);

            foreach (var name in machedName)
            {
                Console.Write(name + " ");
            }
        }
    }
}
