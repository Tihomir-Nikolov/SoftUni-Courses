using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> clothers = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                string color = input[0];
                string[] clother = input[1].Split(",");

                if (!clothers.ContainsKey(color))
                {
                    clothers.Add(color, new Dictionary<string, int>());
                    foreach (var item in clother)
                    {
                        if (!clothers[color].ContainsKey(item))
                        {
                            clothers[color].Add(item, 1);
                        }
                        else
                        {
                            clothers[color][item]++;
                        }
                    }
                }
                else
                {
                    foreach (var item in clother)
                    {
                        if (!clothers[color].ContainsKey(item))
                        {
                            clothers[color].Add(item, 1);
                        }
                        else
                        {
                            clothers[color][item]++;
                        }
                    }
                }
              
            }
            string[] inputEnd = Console.ReadLine().Split();
            foreach (var color in clothers)
            {
                Console.WriteLine($"{color.Key}clothes:");
                foreach (var clother in color.Value)
                {

                    if (color.Key.Contains(inputEnd[0]) && clother.Key.Contains(inputEnd[1]))
                    {
                        Console.WriteLine($"* {clother.Key} - {clother.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clother.Key} - {clother.Value}");
                    }
                }
            }
        }
    }
}
