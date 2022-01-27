using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lenght = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int firstSetLenght = lenght[0];
            int secondtSetLenght = lenght[1];
            HashSet<int> first = new HashSet<int>();
            HashSet<int> second = new HashSet<int>();
            for (int i = 0; i < firstSetLenght; i++)
            {
                int number = int.Parse(Console.ReadLine());
                first.Add(number);
            }
            for (int i = 0; i < secondtSetLenght; i++)
            {
                int number = int.Parse(Console.ReadLine());
                second.Add(number);
            }
            foreach (var number in first)
            {
                foreach (var numbers in second)
                {
                    if (number == numbers)
                    {
                        Console.Write($"{number} ");
                    }
                }
            }
        }
    }
}
