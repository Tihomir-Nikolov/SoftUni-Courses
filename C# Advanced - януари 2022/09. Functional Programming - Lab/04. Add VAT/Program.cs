using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> number = Console.ReadLine().Split(", ").Select(decimal.Parse).ToList();
            number = number.Select(x => x + x * 0.2m).ToList();
            number.ForEach(x => Console.WriteLine($"{x:f2}"));
        }
    }
}
