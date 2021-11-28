using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04._Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"@(?<name>[A-z]+)[^:@\-!>]*:(?<population>[\d]+)[^:@\-!>]*!(?<type>[A,D])![^:@\-!>]*->(?<soldiers>[\d]+)";
            int n = int.Parse(Console.ReadLine());
            List<string> attacked = new List<string>();
            List<string> destroyed = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string messege = Console.ReadLine();
                int sum = messege.ToLower().Count(x => x == 's' || x == 't' || x == 'a' || x == 'r');
                string decryptedMessage = "";
                foreach (char charType in messege)
                {
                    decryptedMessage += (char)(charType - sum);
                }
                Match mached = Regex.Match(decryptedMessage, regex, RegexOptions.IgnoreCase);
                if (mached.Success)
                {
                    string name = mached.Groups["name"].Value;
                    int population = int.Parse(mached.Groups["population"].Value);
                    char type = char.Parse(mached.Groups["type"].Value);
                    int soldiers = int.Parse(mached.Groups["soldiers"].Value);

                    if (type == 'A')
                    {
                        attacked.Add(name);
                    }
                    else
                    {
                        destroyed.Add(name);
                    }
                }
            }
            Console.WriteLine($"Attacked planets: {attacked.Count}");
            attacked.OrderBy(x => x).ToList().ForEach(planetName => Console.WriteLine($"-> {planetName}"));
            Console.WriteLine($"Destroyed planets: {destroyed.Count}");
            destroyed.OrderBy(x => x).ToList().ForEach(planetName => Console.WriteLine($"-> {planetName}"));
        }
    }
}
