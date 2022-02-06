using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
            Console.WriteLine(numbers.Count);
            Console.WriteLine(string.Join(", ", numbers.Sum()));
        }
    }
}
