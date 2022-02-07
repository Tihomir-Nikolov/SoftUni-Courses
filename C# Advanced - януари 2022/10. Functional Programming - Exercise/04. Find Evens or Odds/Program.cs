using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int startIndex = input[0];
            int endIndex = input[1];
            Predicate<int> isEven = number => number % 2 == 0;
            List<int> numbers = new List<int>();
            for (int i = startIndex; i <= endIndex; i++)
            {
                numbers.Add(i);
            }
            string evenOdd = Console.ReadLine();
            if (evenOdd == "even")
            {
                Console.WriteLine(string.Join(" ", numbers.Where(x => isEven(x))));
            }
            else
            {
                Console.WriteLine(string.Join(" ", numbers.Where(x => !isEven(x))));
            }
        }
    }
}
