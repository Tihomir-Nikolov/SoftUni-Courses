using System;
using System.Collections.Generic;

namespace _05._Cities_by_Continent
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> cities = new Dictionary<string, Dictionary<string, List<string>>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string continent = input[0];
                string country = input[1];
                string city = input[2];
                if (!cities.ContainsKey(continent))
                {
                    cities.Add(continent, new Dictionary<string, List<string>>());

                }
                if (!cities[continent].ContainsKey(country))
                {
                    cities[continent].Add(country, new List<string>());
                }
                cities[continent][country].Add(city);
            }
            foreach (var continent in cities)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"{country.Key} -> {string.Join(", ", country.Value)}");
                   
                }
            }
        }
    }
}
