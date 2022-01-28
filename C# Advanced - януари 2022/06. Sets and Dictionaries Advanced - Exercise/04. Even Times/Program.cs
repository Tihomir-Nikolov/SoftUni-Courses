using System;
using System.Collections.Generic;

namespace _04._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n < 2)
            {
                return;
            }
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (!numbers.ContainsKey(input))
                {
                    numbers.Add(input , 0);
                }
                else
                {
                    numbers[input] = 1;
                   
                }
            }
            foreach (var item in numbers)
            {
                if (item.Value > 0)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}
