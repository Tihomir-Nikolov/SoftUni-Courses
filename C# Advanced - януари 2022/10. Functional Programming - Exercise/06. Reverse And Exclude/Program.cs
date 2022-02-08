using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number = Console.ReadLine().Split().Select(int.Parse).ToList<int>();

            int n = int.Parse(Console.ReadLine());

            Func<int, int, bool> isDivisible = (x, y) => x % y != 0;

            List<int> result = number.Where(x => isDivisible(x, n)).Reverse().ToList();

            Console.WriteLine(string.Join(" ", result));

        }
    }
}
